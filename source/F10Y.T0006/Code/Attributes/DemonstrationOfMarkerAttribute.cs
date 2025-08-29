using System;

using F10Y.T0000;


namespace F10Y.T0006
{
    /// <summary>
    /// Marker attribute indicating a method is a demonstration of some other member (can be any member, as only an identity string is required, and any member can have an identity string).
    /// </summary>
    /// <remarks>
    /// The marker attribute is useful for explicitly marking a demonstration as being a demonstration of something, at the time the demonstration is being created.
    /// </remarks>
    [AttributeUsage(
        AttributeTargets.Method, // Only apply to methods, since a demonstration will only be a method (and applying to a type full of methods would be too broad).
        AllowMultiple = true, // A method can be a demonstration of multiple things.
        Inherited = false  // Applied to methods, inheritance should not be an issue, but for completeness.
        )]
    [MarkerAttributeMarker]
    public class DemonstrationOfMarkerAttribute : Attribute
    {
        /// <summary>
        /// The identity string of the thing being demonstrated.
        /// </summary>
        /// <remarks>
        /// For identity string generation, see M:F10Y.L0030.IIdentityStringOperator.Get_IdentityString(System.Reflection.MemberInfo).
        /// </remarks>
        // Not a property, a constructor argument.
        // Survey logic will use this fact.
        public string Target_IdentityString { get; }


        public DemonstrationOfMarkerAttribute(
            string target_IdentityString)
        {
            this.Target_IdentityString = target_IdentityString;
        }
    }
}
