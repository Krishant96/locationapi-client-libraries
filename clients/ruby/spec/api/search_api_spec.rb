=begin
#Location API

#Geolocation, Geocoding and Maps

OpenAPI spec version: 2.0.0

Generated by: https://openapi-generator.tech
OpenAPI Generator version: 3.3.4

=end

require 'spec_helper'
require 'json'

# Unit tests for unwiredClient::SEARCHApi
# Automatically generated by openapi-generator (https://openapi-generator.tech)
# Please update as you see appropriate
describe 'SEARCHApi' do
  before do
    # run before each test
    @instance = unwiredClient::SEARCHApi.new
  end

  after do
    # run after each test
  end

  describe 'test an instance of SEARCHApi' do
    it 'should create an instance of SEARCHApi' do
      expect(@instance).to be_instance_of(unwiredClient::SEARCHApi)
    end
  end

  # unit tests for search
  # Forward Geocoding
  # The Search API allows converting addresses, such as a street address, into geographic coordinates (latitude and longitude). These coordinates can serve various use-cases, from placing markers on a map to helping algorithms determine nearby bus stops. This process is also known as Forward Geocoding.
  # @param q Address to geocode
  # @param [Hash] opts the optional parameters
  # @option opts [String] :viewbox The preferred area to find search results.  To restrict results to those within the viewbox, use along with the bounded option. Tuple of 4 floats. Any two corner points of the box - &#x60;max_lon,max_lat,min_lon,min_lat&#x60; or &#x60;min_lon,min_lat,max_lon,max_lat&#x60; - are accepted in any order as long as they span a real box. 
  # @option opts [Integer] :limit Limit the number of returned results. Default is 10.
  # @option opts [String] :accept_language Preferred language order for showing search results, overrides the value specified in the Accept-Language HTTP header. Defaults to en. To use native language for the response when available, use accept-language&#x3D;native
  # @option opts [String] :countrycodes Limit search to a list of countries.
  # @return [Object]
  describe 'search test' do
    it 'should work' do
      # assertion here. ref: https://www.relishapp.com/rspec/rspec-expectations/docs/built-in-matchers
    end
  end

end
