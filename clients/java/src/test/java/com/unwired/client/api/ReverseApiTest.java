/*
 * Location API
 * Geolocation, Geocoding and Maps
 *
 * OpenAPI spec version: 2.0.0
 * 
 *
 * NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
 * https://openapi-generator.tech
 * Do not edit the class manually.
 */


package com.unwired.client.api;

import unwired.ApiException;
import org.junit.Test;
import org.junit.Ignore;

import java.util.ArrayList;
import java.util.HashMap;
import java.util.List;
import java.util.Map;

/**
 * API tests for ReverseApi
 */
@Ignore
public class ReverseApiTest {

    private final ReverseApi api = new ReverseApi();

    
    /**
     * Reverse Geocoding
     *
     * Reverse geocoding is the process of converting a coordinate or location (latitude, longitude) to a readable address or place name. This permits the identification of nearby street addresses, places, and/or area subdivisions such as a neighborhood, county, state, or country.
     *
     * @throws ApiException
     *          if the Api call fails
     */
    @Test
    public void reverseTest() throws ApiException {
        Double lat = null;
        Double lon = null;
        Long zoom = null;
        String acceptLanguage = null;
        Object response = api.reverse(lat, lon, zoom, acceptLanguage);

        // TODO: test validations
    }
    
}
