namespace Bookify.Domain.Shared;

public record Currency
{
    // Available currencies
    internal static readonly Currency None = new("");
    public static readonly Currency Usd = new("USD");
    public static readonly Currency Eur = new("EUR");

    /// <summary>
    /// Constructor
    /// </summary>
    /// <param name="code"></param>
    private Currency(string code) => Code = code;


    public string Code { get; init; }

    /// <summary>
    /// Get a currency object from string code reference
    /// </summary>
    /// <param name="code"></param>
    /// <returns></returns>
    public static Currency FromCode(string code)
    {
        return All.FirstOrDefault(c => c.Code == code) ??
               throw new ApplicationException("The currency code is invalid.");
    }

    /// <summary>
    /// Shows to external the list of available currencies
    /// </summary>
    public static readonly IReadOnlyCollection<Currency> All = new[]
    {
        Usd,
        Eur
    };

};