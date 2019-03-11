# Location API
#
# Geolocation, Geocoding and Maps
#
# OpenAPI spec version: 2.0.0
# 
# Generated by: https://openapi-generator.tech


#' AddressSchema Class
#'
#' @field lat 
#' @field lon 
#' @field display_name 
#' @field house_number 
#' @field road 
#' @field neighborhood 
#' @field suburb 
#' @field city 
#' @field county 
#' @field country 
#' @field country_code 
#' @field postal_code 
#'
#' @importFrom R6 R6Class
#' @importFrom jsonlite fromJSON toJSON
#' @export
AddressSchema <- R6::R6Class(
  'AddressSchema',
  public = list(
    `lat` = NULL,
    `lon` = NULL,
    `display_name` = NULL,
    `house_number` = NULL,
    `road` = NULL,
    `neighborhood` = NULL,
    `suburb` = NULL,
    `city` = NULL,
    `county` = NULL,
    `country` = NULL,
    `country_code` = NULL,
    `postal_code` = NULL,
    initialize = function(`lat`, `lon`, `display_name`, `house_number`, `road`, `neighborhood`, `suburb`, `city`, `county`, `country`, `country_code`, `postal_code`){
      if (!missing(`lat`)) {
        stopifnot(is.character(`lat`), length(`lat`) == 1)
        self$`lat` <- `lat`
      }
      if (!missing(`lon`)) {
        stopifnot(is.character(`lon`), length(`lon`) == 1)
        self$`lon` <- `lon`
      }
      if (!missing(`display_name`)) {
        stopifnot(is.character(`display_name`), length(`display_name`) == 1)
        self$`display_name` <- `display_name`
      }
      if (!missing(`house_number`)) {
        stopifnot(is.character(`house_number`), length(`house_number`) == 1)
        self$`house_number` <- `house_number`
      }
      if (!missing(`road`)) {
        stopifnot(is.character(`road`), length(`road`) == 1)
        self$`road` <- `road`
      }
      if (!missing(`neighborhood`)) {
        stopifnot(is.character(`neighborhood`), length(`neighborhood`) == 1)
        self$`neighborhood` <- `neighborhood`
      }
      if (!missing(`suburb`)) {
        stopifnot(is.character(`suburb`), length(`suburb`) == 1)
        self$`suburb` <- `suburb`
      }
      if (!missing(`city`)) {
        stopifnot(is.character(`city`), length(`city`) == 1)
        self$`city` <- `city`
      }
      if (!missing(`county`)) {
        stopifnot(is.character(`county`), length(`county`) == 1)
        self$`county` <- `county`
      }
      if (!missing(`country`)) {
        stopifnot(is.character(`country`), length(`country`) == 1)
        self$`country` <- `country`
      }
      if (!missing(`country_code`)) {
        stopifnot(is.character(`country_code`), length(`country_code`) == 1)
        self$`country_code` <- `country_code`
      }
      if (!missing(`postal_code`)) {
        stopifnot(is.character(`postal_code`), length(`postal_code`) == 1)
        self$`postal_code` <- `postal_code`
      }
    },
    toJSON = function() {
      AddressSchemaObject <- list()
      if (!is.null(self$`lat`)) {
        AddressSchemaObject[['lat']] <- self$`lat`
      }
      if (!is.null(self$`lon`)) {
        AddressSchemaObject[['lon']] <- self$`lon`
      }
      if (!is.null(self$`display_name`)) {
        AddressSchemaObject[['display_name']] <- self$`display_name`
      }
      if (!is.null(self$`house_number`)) {
        AddressSchemaObject[['house_number']] <- self$`house_number`
      }
      if (!is.null(self$`road`)) {
        AddressSchemaObject[['road']] <- self$`road`
      }
      if (!is.null(self$`neighborhood`)) {
        AddressSchemaObject[['neighborhood']] <- self$`neighborhood`
      }
      if (!is.null(self$`suburb`)) {
        AddressSchemaObject[['suburb']] <- self$`suburb`
      }
      if (!is.null(self$`city`)) {
        AddressSchemaObject[['city']] <- self$`city`
      }
      if (!is.null(self$`county`)) {
        AddressSchemaObject[['county']] <- self$`county`
      }
      if (!is.null(self$`country`)) {
        AddressSchemaObject[['country']] <- self$`country`
      }
      if (!is.null(self$`country_code`)) {
        AddressSchemaObject[['country_code']] <- self$`country_code`
      }
      if (!is.null(self$`postal_code`)) {
        AddressSchemaObject[['postal_code']] <- self$`postal_code`
      }

      AddressSchemaObject
    },
    fromJSON = function(AddressSchemaJson) {
      AddressSchemaObject <- jsonlite::fromJSON(AddressSchemaJson)
      if (!is.null(AddressSchemaObject$`lat`)) {
        self$`lat` <- AddressSchemaObject$`lat`
      }
      if (!is.null(AddressSchemaObject$`lon`)) {
        self$`lon` <- AddressSchemaObject$`lon`
      }
      if (!is.null(AddressSchemaObject$`display_name`)) {
        self$`display_name` <- AddressSchemaObject$`display_name`
      }
      if (!is.null(AddressSchemaObject$`house_number`)) {
        self$`house_number` <- AddressSchemaObject$`house_number`
      }
      if (!is.null(AddressSchemaObject$`road`)) {
        self$`road` <- AddressSchemaObject$`road`
      }
      if (!is.null(AddressSchemaObject$`neighborhood`)) {
        self$`neighborhood` <- AddressSchemaObject$`neighborhood`
      }
      if (!is.null(AddressSchemaObject$`suburb`)) {
        self$`suburb` <- AddressSchemaObject$`suburb`
      }
      if (!is.null(AddressSchemaObject$`city`)) {
        self$`city` <- AddressSchemaObject$`city`
      }
      if (!is.null(AddressSchemaObject$`county`)) {
        self$`county` <- AddressSchemaObject$`county`
      }
      if (!is.null(AddressSchemaObject$`country`)) {
        self$`country` <- AddressSchemaObject$`country`
      }
      if (!is.null(AddressSchemaObject$`country_code`)) {
        self$`country_code` <- AddressSchemaObject$`country_code`
      }
      if (!is.null(AddressSchemaObject$`postal_code`)) {
        self$`postal_code` <- AddressSchemaObject$`postal_code`
      }
    },
    toJSONString = function() {
       sprintf(
        '{
           "lat": %s,
           "lon": %s,
           "display_name": %s,
           "house_number": %s,
           "road": %s,
           "neighborhood": %s,
           "suburb": %s,
           "city": %s,
           "county": %s,
           "country": %s,
           "country_code": %s,
           "postal_code": %s
        }',
        self$`lat`,
        self$`lon`,
        self$`display_name`,
        self$`house_number`,
        self$`road`,
        self$`neighborhood`,
        self$`suburb`,
        self$`city`,
        self$`county`,
        self$`country`,
        self$`country_code`,
        self$`postal_code`
      )
    },
    fromJSONString = function(AddressSchemaJson) {
      AddressSchemaObject <- jsonlite::fromJSON(AddressSchemaJson)
      self$`lat` <- AddressSchemaObject$`lat`
      self$`lon` <- AddressSchemaObject$`lon`
      self$`display_name` <- AddressSchemaObject$`display_name`
      self$`house_number` <- AddressSchemaObject$`house_number`
      self$`road` <- AddressSchemaObject$`road`
      self$`neighborhood` <- AddressSchemaObject$`neighborhood`
      self$`suburb` <- AddressSchemaObject$`suburb`
      self$`city` <- AddressSchemaObject$`city`
      self$`county` <- AddressSchemaObject$`county`
      self$`country` <- AddressSchemaObject$`country`
      self$`country_code` <- AddressSchemaObject$`country_code`
      self$`postal_code` <- AddressSchemaObject$`postal_code`
    }
  )
)