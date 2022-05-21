using System;

namespace Enrollee.Infrastructure.Setting;

public class AuthOptions
{
    public string Issuer { get; private init; }

    public string Audience { get; private init; }

    public string Key { get; private init; }
}
