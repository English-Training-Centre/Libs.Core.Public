using Microsoft.AspNetCore.Http;

namespace Libs.Core.Public.src.DTOs.Requests;

public sealed record SettingsFlyerCreateRequest
(
    IFormFile Image,
    long EnrolmentFee,

    // On-Site
    long OnSiteIntensiveA,
    long OnSiteIntensiveAA,
    long OnSiteIntensiveB,
    long OnSiteIntensiveBB,
    long OnSiteIntensiveC,

    long OnSitePrivateA,
    long OnSitePrivateAA,
    long OnSitePrivateB,
    long OnSitePrivateBB,
    long OnSitePrivateC,

    long OnSiteRegularA,
    long OnSiteRegularAA,
    long OnSiteRegularB,
    long OnSiteRegularBB,
    long OnSiteRegularC,

    // Online   
    long OnlineIntensiveA,
    long OnlineIntensiveAA,
    long OnlineIntensiveB,
    long OnlineIntensiveBB,
    long OnlineIntensiveC,

    long OnlinePrivateA,
    long OnlinePrivateAA,
    long OnlinePrivateB,
    long OnlinePrivateBB,
    long OnlinePrivateC,

    long OnlineRegularA,
    long OnlineRegularAA,
    long OnlineRegularB,
    long OnlineRegularBB,
    long OnlineRegularC
);