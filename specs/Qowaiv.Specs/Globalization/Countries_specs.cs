﻿namespace Globalization.Countries_specs;

public class All
{
    [Test]
    public void _260_Countries()
        => Country.All.Should().HaveCount(260);

    [Test]
    public void _250_at_January_2016()
        => Country.GetExisting(new Date(2016, 01, 01)).Should().HaveCount(250);

    [Test]
    public void zero_at_1973()
        => Country.GetExisting(new Date(1973, 12, 31)).Should().BeEmpty(because: "before the ISO standard was introduced.");

#if NET6_0_OR_GREATER
    [Test]
    public void get_existing_by_date_only()
        => Country.GetExisting(new DateOnly(2016, 01, 01)).Should().HaveCount(250);
#endif
}
