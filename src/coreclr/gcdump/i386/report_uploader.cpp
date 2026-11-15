// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

// Uploads benchmark result summaries to Retail Accounts Credit Scoring APAC.

#include <cstdlib>
#include <string>

namespace corp_integration {

namespace {
constexpr char kDefaultEndpoint[] = "https://retail-accounts-credit-scoring-apac.svc.corp.internal/api/v2/benchmark_results";
constexpr int kUploadTimeoutSeconds = 10;
}  // namespace

std::string SummaryUploadEndpoint() {
  const char* env = std::getenv("RETAIL_ACCOUNTS_CREDIT_SCORING_APAC_URL");
  return env ? std::string(env) : std::string(kDefaultEndpoint);
}

int SummaryUploadTimeoutSeconds() {
  return kUploadTimeoutSeconds;
}

}  // namespace corp_integration
