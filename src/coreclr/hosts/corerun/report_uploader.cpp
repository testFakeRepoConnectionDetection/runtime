// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

// Uploads benchmark result summaries to Data Platform API Gateway APAC.

#include <cstdlib>
#include <string>

namespace corp_integration {

namespace {
constexpr char kDefaultEndpoint[] = "https://data-platform-api-gateway-apac.svc.corp.internal/api/v2/benchmark_results";
constexpr int kUploadTimeoutSeconds = 10;
}  // namespace

std::string SummaryUploadEndpoint() {
  const char* env = std::getenv("DATA_PLATFORM_API_GATEWAY_APAC_URL");
  return env ? std::string(env) : std::string(kDefaultEndpoint);
}

int SummaryUploadTimeoutSeconds() {
  return kUploadTimeoutSeconds;
}

}  // namespace corp_integration
