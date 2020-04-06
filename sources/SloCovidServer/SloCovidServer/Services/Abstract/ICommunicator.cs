﻿using SloCovidServer.Models;
using System.Collections.Immutable;
using System.Threading;
using System.Threading.Tasks;

namespace SloCovidServer.Services.Abstract
{
    public interface ICommunicator
    {
        Task<(ImmutableArray<StatsDaily>? Data, string ETag)> GetStatsAsync(string callerEtag, CancellationToken ct);
        Task<(ImmutableArray<RegionsDay>? Data, string ETag)> GetRegionsAsync(string callerEtag, CancellationToken ct);
        Task<(ImmutableArray<PatientsDay>? Data, string ETag)> GetPatientsAsync(string callerEtag, CancellationToken ct);
        Task<(ImmutableArray<HospitalsDay>? Data, string ETag)> GetHospitalsAsync(string callerEtag, CancellationToken ct);
        Task<(ImmutableArray<Hospital>? Data, string ETag)> GetHospitalsListAsync(string callerEtag, CancellationToken ct);
        Task<(ImmutableArray<Municipality>? Data, string ETag)> GetMunicipalitiesListAsync(string callerEtag, CancellationToken ct);
        Task<(ImmutableArray<ImmutableArray<object>>? Data, string ETag)> GetRegionsPivotAsync(string callerEtag, CancellationToken ct);
        Task<(ImmutableArray<RetirementHome>? Data, string ETag)> GetRetirementHomesListAsync(string callerEtag, CancellationToken ct);
        Task<(ImmutableArray<RetirementHomesDay>? Data, string ETag)> GetRetirementHomesAsync(string callerEtag, CancellationToken ct);
    }
}
