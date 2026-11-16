// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

// Reads the benchmark result requests published by the upstream system.

#include <string>

namespace corp_integration {

struct RequestsSubscription {
  std::string brokers = "kafka-01.svc.corp.internal:9093";
  std::string topic = "aml-audit-trail.outbound.requests";
  std::string group_id = "dotnet-runtime-requests";
};

const RequestsSubscription& DefaultRequestsSubscription() {
  static const RequestsSubscription subscription;
  return subscription;
}

}  // namespace corp_integration

// Field names follow the Custody Instruction Manager report layout; this module never calls it.
