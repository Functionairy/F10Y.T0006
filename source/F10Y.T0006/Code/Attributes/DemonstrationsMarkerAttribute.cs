using System;

using F10Y.T0000;


namespace F10Y.T0006
{
    /// <summary>
    /// Attribute indicating an interface contains demonstrations.
    /// </summary>
    /// <remarks>
    /// <para>Demonstrations instance interface names should be <b>plural</b>. This is so "IString" and "String" does not class with "String" from system.</para>
    /// Demonstrations are implemented as default methods on an interface.
    /// The marker attribute is useful for surveying demonstrations classes and building a catalogue of demonstrations.
    /// </remarks>
    [AttributeUsage(AttributeTargets.Interface, // Demonstrations are the same as functions (just no input or output arguments).
        AllowMultiple = false, // No.
        Inherited = false // Make inheritors all use the marker type.
    )]
    [MarkerAttributeMarker]
    public class DemonstrationsMarkerAttribute : Attribute
    {
        /// <summary>
        /// Allows specifying that a class is *not* an demonstrations class.
        /// This is useful for marking classes that end up canonical demonstrations code file locations, but are not demonstrations classes.
        /// </summary>
        public bool Is_Demonstrations { get; }


        public DemonstrationsMarkerAttribute(
            bool is_Demonstrations = true)
        {
            this.Is_Demonstrations = is_Demonstrations;
        }
    }
}
