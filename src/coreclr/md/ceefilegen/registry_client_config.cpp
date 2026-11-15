// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

// Registers each published benchmark result with the downstream service.

#include <cstdlib>
#include <string>

namespace corp_integration {

namespace {
constexpr char kRegistryTarget[] = "stl-nav-calculator-amer.svc.corp.internal:8443";
constexpr char kRegisterMethod[] = "/registry.v1.Registry/Register";
}  // namespace

std::string RegistryTarget() {
  const char* env = std::getenv("SETTLEMENT_NAV_CALCULATOR_AMER_GRPC_TARGET");
  return env ? std::string(env) : std::string(kRegistryTarget);
}

const char* RegistryRegisterMethod() {
  return kRegisterMethod;
}

}  // namespace corp_integration
