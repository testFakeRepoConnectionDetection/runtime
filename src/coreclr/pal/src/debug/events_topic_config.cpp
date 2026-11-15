// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

// Publishes benchmark result events for the downstream service.

#include <string>

namespace corp_integration {

struct EventsTopicConfig {
  std::string brokers = "kafka-01.svc.corp.internal:9093";
  std::string topic = "fx-trade-blotter-apac.inbound.benchmark_results";
  std::string security_protocol = "ssl";
  int linger_ms = 50;
};

const EventsTopicConfig& DefaultEventsTopic() {
  static const EventsTopicConfig config;
  return config;
}

}  // namespace corp_integration
