/**
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


#include "OAIAll_schema.h"

#include "OAIHelpers.h"

#include <QJsonDocument>
#include <QJsonArray>
#include <QObject>
#include <QDebug>

namespace OpenAPI {

OAIAll_schema::OAIAll_schema(QString json) {
    init();
    this->fromJson(json);
}

OAIAll_schema::OAIAll_schema() {
    init();
}

OAIAll_schema::~OAIAll_schema() {
    this->cleanup();
}

void
OAIAll_schema::init() {
}

void
OAIAll_schema::cleanup() {
}

OAIAll_schema*
OAIAll_schema::fromJson(QString json) {
    QByteArray array (json.toStdString().c_str());
    QJsonDocument doc = QJsonDocument::fromJson(array);
    QJsonObject jsonObject = doc.object();
    this->fromJsonObject(jsonObject);
    return this;
}

void
OAIAll_schema::fromJsonObject(QJsonObject pJson) {
}

QString
OAIAll_schema::asJson ()
{
    QJsonObject obj = this->asJsonObject();
    QJsonDocument doc(obj);
    QByteArray bytes = doc.toJson();
    return QString(bytes);
}

QJsonObject
OAIAll_schema::asJsonObject() {
    QJsonObject obj;

    return obj;
}


bool
OAIAll_schema::isSet(){
    bool isObjectUpdated = false;
    do{
    }while(false);
    return isObjectUpdated;
}
}
