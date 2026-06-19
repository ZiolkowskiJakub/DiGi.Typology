using DiGi.Core.Interfaces;
using DiGi.Typology.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace DiGi.Typology.Classes
{
    /// <summary>
    /// Represents an abstract solver for applying typology filters to a collection of objects to resolve typologies.
    /// </summary>
    /// <typeparam name="TTypologyFilter">The type of the typology filter.</typeparam>
    /// <typeparam name="TObject">The type of objects being evaluated.</typeparam>
    public abstract class TypologyFilterSolver<TTypologyFilter, TObject> : IOneToOneSolver<TTypologyFilter, Typology> where TTypologyFilter : ITypologyFilter<TTypologyFilter>
    {
        /// <summary>
        /// Gets or sets the input typology filter used for solving.
        /// </summary>
        public TTypologyFilter? Input { get; set; }

        /// <summary>
        /// Gets or sets the collection of source objects to evaluate.
        /// </summary>
        public IEnumerable<TObject>? Objects { get; set; }

        /// <summary>
        /// Gets the resulting typology output from the solving process.
        /// </summary>
        public Typology? Output { get; private set; }

        /// <summary>
        /// Default TypologyItem for Typology root
        /// </summary>
        public TypologyItem? TypologyItem { get; set; } = null;

        public TypologyFilterSolver()
        {

        }

        public TypologyFilterSolver(TTypologyFilter? typologyFilter, IEnumerable<TObject>? objects)
        {
            Input = typologyFilter;
            Objects = objects;
        }

        /// <summary>
        /// Solves and populates the typology output by evaluating the input filter against the objects.
        /// </summary>
        /// <returns>True if solving succeeded; otherwise, false.</returns>
        public bool Solve()
        {
            if (Input is null || Objects is null || !Objects.Any())
            {
                return false;
            }

            Output = TypologyItem is null ? new Typology(string.Empty, string.Empty) : new Typology(TypologyItem);

            Solve(Output, Input, Objects);

            return true;
        }

        /// <summary>
        /// Gets a unique reference identifier string for the specified object.
        /// </summary>
        /// <param name="object">The object to identify.</param>
        /// <returns>The unique identifier string, or null.</returns>
        protected virtual string? GetReference(TObject? @object)
        {
            if (@object is null)
            {
                return null;
            }

            if (@object is IUniqueObject uniqueObject)
            {
                return uniqueObject.UniqueId;
            }

            return @object.ToString();
        }

        /// <summary>
        /// Creates a new typology item based on the current filter context and evaluated rule data.
        /// </summary>
        /// <param name="typologyFilter">The current typology filter context.</param>
        /// <param name="typologyFilterRuleData">The evaluated rule data.</param>
        /// <returns>A new typology item, or null.</returns>
        protected abstract TypologyItem? GetTypologyItem(TTypologyFilter? typologyFilter, ITypologyFilterRuleData? typologyFilterRuleData);

        /// <summary>
        /// Extracts the target evaluation value from the specified object using the current filter context.
        /// </summary>
        /// <param name="typologyFilter">The current typology filter context.</param>
        /// <param name="object">The object to extract the value from.</param>
        /// <returns>The extracted value, or null.</returns>
        protected abstract object? GetValue(TTypologyFilter? typologyFilter, TObject? @object);
        private List<Typology>? Solve(Typology? typology, TTypologyFilter typologyFilter, IEnumerable<TObject>? objects)
        {
            if (typology is null || typologyFilter is null || objects is null)
            {
                return null;
            }

            Dictionary<ITypologyFilterRuleData, List<TObject>> dictionary = [];

            if (typologyFilter.Rule is ITypologyFilterRule typologyFilterRule_Rule)
            {
                foreach (TObject @object in objects)
                {
                    object? object_Value = GetValue(typologyFilter, @object);

                    ITypologyFilterRuleData? typologyFilterRuleData = typologyFilterRule_Rule.RuleData(object_Value);
                    if (typologyFilterRuleData is null)
                    {
                        continue;
                    }

                    if (!dictionary.TryGetValue(typologyFilterRuleData, out List<TObject>? objects_Temp) || objects_Temp is null)
                    {
                        objects_Temp = [];
                        dictionary[typologyFilterRuleData] = objects_Temp;
                    }

                    objects_Temp.Add(@object);
                }
            }

            List<Typology> typologies_Result = [];

            foreach (KeyValuePair<ITypologyFilterRuleData, List<TObject>> keyValuePair in dictionary)
            {
                TypologyItem? typologyItem = GetTypologyItem(typologyFilter, keyValuePair.Key);
                if (typologyItem is null)
                {
                    continue;
                }

                Typology? typology_Temp = typology.Update(typologyItem);
                if (typology_Temp is null)
                {
                    continue;
                }

                foreach (TObject @object in keyValuePair.Value)
                {
                    string? string_Reference = GetReference(@object);
                    if (string_Reference is null)
                    {
                        continue;
                    }

                    typology_Temp.AddReference(string_Reference);
                }

                if (typologyFilter.Filter is TTypologyFilter typologyFilter_Temp)
                {
                    Solve(typology_Temp, typologyFilter_Temp, keyValuePair.Value);
                }

                typologies_Result.Add(typology_Temp);
            }

            return typologies_Result;
        }
    }
}