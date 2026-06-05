using Microsoft.Extensions.DependencyInjection;
using Soenneker.Instantly.Accounts.Registrars;
using Soenneker.Instantly.Analytics.Registrars;
using Soenneker.Instantly.Leads.Registrars;
using Soenneker.Instantly.Unibox.Registrars;
using Soenneker.Instantly.Verification.Registrars;

namespace Soenneker.Instantly.Suite.Registrars;

/// <summary>
/// A comprehensive suite of utility libraries for Instantly.ai's API
/// </summary>
public static class InstantlySuiteRegistrar
{
    /// <summary>
    /// Adds instantly suite singleton.
    /// </summary>
    /// <param name="services">The service collection.</param>
    /// <returns>The result of the operation.</returns>
    public static IServiceCollection AddInstantlySuiteSingleton(this IServiceCollection services)
    {
        services.AddInstantlyVerificationUtilAsSingleton()
                .AddInstantlyAccountsUtilAsSingleton()
                .AddInstantlyAnalyticsUtilAsSingleton()
                .AddInstantlyUniboxUtilAsSingleton()
                .AddInstantlyLeadUtilAsSingleton();

        return services;
    }

    /// <summary>
    /// Adds instantly suite as scoped.
    /// </summary>
    /// <param name="services">The service collection.</param>
    /// <returns>The result of the operation.</returns>
    public static IServiceCollection AddInstantlySuiteAsScoped(this IServiceCollection services)
    {
        services.AddInstantlyVerificationUtilAsScoped()
                .AddInstantlyAccountsUtilAsScoped()
                .AddInstantlyAnalyticsUtilAsScoped()
                .AddInstantlyUniboxUtilAsScoped()
                .AddInstantlyLeadUtilAsScoped();

        return services;
    }
}