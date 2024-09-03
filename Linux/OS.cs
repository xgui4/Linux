namespace Linux;

public class OS
{
    public string Name { get; private set; }
    public string Edition { get; private set; }
    public string Version { get; private set; }
    public string Build { get; private set; }
    public string Architecture { get; private set; } 
    public string Platform { get; private set; }
    public bool IsOpenSource { get; private set; }
    public bool IsActivated { get; private set; }

    public OS(string name, string edition, string version, string build, string architecture, string platform,
        bool isOpenSource, bool isActivated)
    {
        Name = name ?? throw new ArgumentNullException(nameof(name));
        Edition = edition ?? throw new ArgumentNullException(nameof(edition));
        Version = version ?? throw new ArgumentNullException(nameof(version));
        Build = build ?? throw new ArgumentNullException(nameof(build));
        Architecture = architecture ?? throw new ArgumentNullException(nameof(architecture));
        Platform = platform ?? throw new ArgumentNullException(nameof(platform));
        IsOpenSource = isOpenSource;
        IsActivated = isActivated;
    }

    public override string ToString()
    {
        return
            $"{nameof(Name)}: {Name}, {nameof(Edition)}: {Edition}, {nameof(Version)}: {Version}, {nameof(Build)}: {Build}, {nameof(Architecture)}: {Architecture}, {nameof(Platform)}: {Platform}, {nameof(IsOpenSource)}: {IsOpenSource}, {nameof(IsActivated)}: {IsActivated}";
    }
}