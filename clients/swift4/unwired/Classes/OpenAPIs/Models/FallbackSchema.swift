//
// FallbackSchema.swift
//
// Generated by openapi-generator
// https://openapi-generator.tech
//

import Foundation


/** An array of fallback options to enable or disable. */

public struct FallbackSchema: Codable {

    public var all: AllSchema?
    public var ipf: IpfSchema?
    public var lacf: LacfSchema?
    public var scf: ScfSchema?

    public init(all: AllSchema?, ipf: IpfSchema?, lacf: LacfSchema?, scf: ScfSchema?) {
        self.all = all
        self.ipf = ipf
        self.lacf = lacf
        self.scf = scf
    }


}
