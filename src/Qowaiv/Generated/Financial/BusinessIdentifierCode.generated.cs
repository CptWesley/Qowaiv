﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
#nullable enable

namespace Qowaiv.Financial;

public partial struct BusinessIdentifierCode
{
    private BusinessIdentifierCode(string? value) => m_Value = value;

    /// <summary>The inner value of the BIC.</summary>
    private string? m_Value;

    /// <summary>Returns true if the  BIC is empty, otherwise false.</summary>
    [Pure]
    public bool IsEmpty() => m_Value == default;
    /// <summary>Returns true if the  BIC is unknown, otherwise false.</summary>
    [Pure]
    public bool IsUnknown() => m_Value == Unknown.m_Value;
    /// <summary>Returns true if the  BIC is empty or unknown, otherwise false.</summary>
    [Pure]
    public bool IsEmptyOrUnknown() => IsEmpty() || IsUnknown();

    /// <summary>0: Empty, +1: Known, +2: Unknown.</summary>
    [Pure]
    private int Kind()
    {
        if (IsEmpty()) return 0;
        else if (IsUnknown()) return +2;
        else return +1;
    }
}

public partial struct BusinessIdentifierCode : IEquatable<BusinessIdentifierCode>
{
    /// <inheritdoc />
    [Pure]
    public override bool Equals(object? obj) => obj is BusinessIdentifierCode other && Equals(other);

    /// <summary>Returns true if this instance and the other BIC are equal, otherwise false.</summary>
    /// <param name="other">The <see cref="BusinessIdentifierCode" /> to compare with.</param>
    [Pure]
    public bool Equals(BusinessIdentifierCode other) => m_Value == other.m_Value;

    /// <inheritdoc />
    [Pure]
    public override int GetHashCode() => Hash.Code(m_Value);

    /// <summary>Returns true if the left and right operand are equal, otherwise false.</summary>
    /// <param name="left">The left operand.</param>
    /// <param name="right">The right operand</param>
    public static bool operator !=(BusinessIdentifierCode left, BusinessIdentifierCode right) => !(left == right);

    /// <summary>Returns true if the left and right operand are not equal, otherwise false.</summary>
    /// <param name="left">The left operand.</param>
    /// <param name="right">The right operand</param>
    public static bool operator ==(BusinessIdentifierCode left, BusinessIdentifierCode right) => left.Equals(right);
}

public partial struct BusinessIdentifierCode : IComparable, IComparable<BusinessIdentifierCode>
{
    /// <inheritdoc />
    [Pure]
    public int CompareTo(object? obj)
    {
        if (obj is null) { return 1; }
        else if (obj is BusinessIdentifierCode other) { return CompareTo(other); }
        else { throw new ArgumentException($"Argument must be {GetType().Name}.", nameof(obj)); }
    }
    /// <inheritdoc />
    [Pure]
#nullable disable
    public int CompareTo(BusinessIdentifierCode other) => Comparer<string>.Default.Compare(m_Value, other.m_Value);
#nullable enable
}

public partial struct BusinessIdentifierCode : IFormattable
{
    /// <summary>Returns a <see cref="string"/> that represents the BIC.</summary>
    [Pure]
    public override string ToString() => ToString(provider: null);

    /// <summary>Returns a formatted <see cref="string"/> that represents the BIC.</summary>
    /// <param name="format">
    /// The format that describes the formatting.
    /// </param>
    [Pure]
    public string ToString(string? format) => ToString(format, formatProvider: null);

    /// <summary>Returns a formatted <see cref="string"/> that represents the BIC.</summary>
    /// <param name="provider">
    /// The format provider.
    /// </param>
    [Pure]
    public string ToString(IFormatProvider? provider) => ToString(format: null, provider);
}

public partial struct BusinessIdentifierCode : ISerializable
{
    /// <summary>Initializes a new instance of the BIC based on the serialization info.</summary>
    /// <param name="info">The serialization info.</param>
    /// <param name="context">The streaming context.</param>
    private BusinessIdentifierCode(SerializationInfo info, StreamingContext context)
    {
        Guard.NotNull(info, nameof(info));
        m_Value = info.GetValue("Value", typeof(string)) is string val ? val : default(string);
    }

    /// <summary>Adds the underlying property of the BIC to the serialization info.</summary>
    /// <param name="info">The serialization info.</param>
    /// <param name="context">The streaming context.</param>
    void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
        => Guard.NotNull(info, nameof(info)).AddValue("Value", m_Value);
}

public partial struct BusinessIdentifierCode
{
    /// <summary>Creates the BIC from a JSON string.</summary>
    /// <param name="json">
    /// The JSON string to deserialize.
    /// </param>
    /// <returns>
    /// The deserialized BIC.
    /// </returns>
    [Pure]
    public static BusinessIdentifierCode FromJson(string? json) => Parse(json, CultureInfo.InvariantCulture);
}

public partial struct BusinessIdentifierCode : IXmlSerializable
{
    /// <summary>Gets the <see href="XmlSchema" /> to XML (de)serialize the BIC.</summary>
    /// <remarks>
    /// Returns null as no schema is required.
    /// </remarks>
    [Pure]
    XmlSchema? IXmlSerializable.GetSchema() => (XmlSchema?)null;

    /// <summary>Reads the BIC from an <see href="XmlReader" />.</summary>
    /// <param name="reader">An XML reader.</param>
    void IXmlSerializable.ReadXml(XmlReader reader)
    {
        Guard.NotNull(reader, nameof(reader));
        var xml = reader.ReadElementString();
        var val = Parse(xml, CultureInfo.InvariantCulture);
        m_Value = val.m_Value;
    }

    /// <summary>Writes the BIC to an <see href="XmlWriter" />.</summary>
    /// <remarks>
    /// Uses <see cref="ToXmlString()"/>.
    /// </remarks>
    /// <param name="writer">An XML writer.</param>
    void IXmlSerializable.WriteXml(XmlWriter writer)
        => Guard.NotNull(writer, nameof(writer)).WriteString(ToXmlString());
}

public partial struct BusinessIdentifierCode
{
    /// <summary>Converts the <see cref="string"/> to <see cref="BusinessIdentifierCode"/>.</summary>
    /// <param name="s">
    /// A string containing the BIC to convert.
    /// </param>
    /// <returns>
    /// The parsed BIC.
    /// </returns>
    /// <exception cref="FormatException">
    /// <paramref name="s"/> is not in the correct format.
    /// </exception>
    [Pure]
    public static BusinessIdentifierCode Parse(string? s) => Parse(s, null);

    /// <summary>Converts the <see cref="string"/> to <see cref="BusinessIdentifierCode"/>.</summary>
    /// <param name="s">
    /// A string containing the BIC to convert.
    /// </param>
    /// <param name="formatProvider">
    /// The specified format provider.
    /// </param>
    /// <returns>
    /// The parsed BIC.
    /// </returns>
    /// <exception cref="FormatException">
    /// <paramref name="s"/> is not in the correct format.
    /// </exception>
    [Pure]
    public static BusinessIdentifierCode Parse(string? s, IFormatProvider? formatProvider) => TryParse(s, formatProvider) ?? throw new FormatException(QowaivMessages.FormatExceptionBusinessIdentifierCode);

    /// <summary>Converts the <see cref="string"/> to <see cref="BusinessIdentifierCode"/>.</summary>
    /// <param name="s">
    /// A string containing the BIC to convert.
    /// </param>
    /// <returns>
    /// The BIC if the string was converted successfully, otherwise default.
    /// </returns>
    [Pure]
    public static BusinessIdentifierCode? TryParse(string? s) => TryParse(s, null);

    /// <summary>Converts the <see cref="string"/> to <see cref="BusinessIdentifierCode"/>.</summary>
    /// <param name="s">
    /// A string containing the BIC to convert.
    /// </param>
    /// <param name="formatProvider">
    /// The specified format provider.
    /// </param>
    /// <returns>
    /// The BIC if the string was converted successfully, otherwise default.
    /// </returns>
    [Pure]
    public static BusinessIdentifierCode? TryParse(string? s, IFormatProvider? formatProvider) => TryParse(s, formatProvider, out var val) ? val : default(BusinessIdentifierCode?);

    /// <summary>Converts the <see cref="string"/> to <see cref="BusinessIdentifierCode"/>.
    /// A return value indicates whether the conversion succeeded.
    /// </summary>
    /// <param name="s">
    /// A string containing the BIC to convert.
    /// </param>
    /// <param name="result">
    /// The result of the parsing.
    /// </param>
    /// <returns>
    /// True if the string was converted successfully, otherwise false.
    /// </returns>
    [Pure]
    public static bool TryParse(string? s, out BusinessIdentifierCode result) => TryParse(s, null, out result);
}

public partial struct BusinessIdentifierCode
{

    /// <summary>Returns true if the value represents a valid BIC.</summary>
    /// <param name="val">
    /// The <see cref="string"/> to validate.
    /// </param>
    [Pure]
    public static bool IsValid(string? val) => IsValid(val, (IFormatProvider?)null);

    /// <summary>Returns true if the value represents a valid BIC.</summary>
    /// <param name="val">
    /// The <see cref="string"/> to validate.
    /// </param>
    /// <param name="formatProvider">
    /// The <see cref="IFormatProvider"/> to interpret the <see cref="string"/> value with.
    /// </param>
    [Pure]
    public static bool IsValid(string? val, IFormatProvider? formatProvider)
        => !string.IsNullOrWhiteSpace(val)
        && TryParse(val, formatProvider, out _);
}

