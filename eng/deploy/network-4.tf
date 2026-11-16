# Network access of the dotnet-runtime deployment (corp landing zone).

data "aws_security_group" "peer_01" {
  tags = {
    Application = "Regulatory Reporting Evidence Archive APAC"
  }
}

resource "aws_security_group_rule" "ingress_01" {
  type                     = "ingress"
  from_port                = 8443
  to_port                  = 8443
  protocol                 = "tcp"
  security_group_id        = var.service_sg_id
  source_security_group_id = data.aws_security_group.peer_01.id
}

# Commodities Trade Blotter AMER
module "egress_02" {
  source           = "../modules/private-link-consumer"
  endpoint_service = "com.corp.privatelink.ext-gw-226"
  port             = 443
}

data "aws_security_group" "peer_03" {
  tags = {
    Application = "Corporate Accounts Product Catalog"
  }
}

resource "aws_security_group_rule" "ingress_03" {
  type                     = "ingress"
  from_port                = 8443
  to_port                  = 8443
  protocol                 = "tcp"
  security_group_id        = var.service_sg_id
  source_security_group_id = data.aws_security_group.peer_03.id
}

# Credit Hedging Service AMER
module "egress_04" {
  source           = "../modules/private-link-consumer"
  endpoint_service = "com.corp.privatelink.ext-gw-924"
  port             = 443
}

module "egress_05" {
  source           = "../modules/private-link-consumer"
  endpoint_service = "com.corp.privatelink.deposits-interest-engine-amer"
  port             = 443
}
