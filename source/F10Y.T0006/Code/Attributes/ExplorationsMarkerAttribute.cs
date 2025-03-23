using System;

using F10Y.T0000;


namespace F10Y.T0006
{
    /// <summary>
    /// Attribute indicating an interface contains explorations.
    /// </summary>
    /// <remarks>
    /// <para>Explorations instance interface names should be <b>plural</b>. This is so "IString" and "String" does not class with "String" from system.</para>
    /// Explorations are implemented as default methods on an interface.
    /// The marker attribute is useful for surveying explorations classes and building a catalogue of explorations.
    /// </remarks>
    [AttributeUsage(AttributeTargets.Interface, // Explorations are the same as functions (just no input or output arguments).
        AllowMultiple = false, // No.
        Inherited = false // Make inheritors all use the marker type.
    )]
    [MarkerAttributeMarker]
    public class ExplorationsMarkerAttribute : Attribute
    {
        /// <summary>
        /// Allows specifying that a class is *not* an explorations class.
        /// This is useful for marking classes that end up canonical explorations code file locations, but are not explorations classes.
        /// </summary>
        public bool Is_Explorations { get; }


        public ExplorationsMarkerAttribute(
            bool is_Explorations = true)
        {
            this.Is_Explorations = is_Explorations;
        }
    }
}
