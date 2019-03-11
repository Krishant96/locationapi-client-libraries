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


#include "OAIReverse_response_schema.h"

#include "OAIHelpers.h"

#include <QJsonDocument>
#include <QJsonArray>
#include <QObject>
#include <QDebug>

namespace OpenAPI {

OAIReverse_response_schema::OAIReverse_response_schema(QString json) {
    init();
    this->fromJson(json);
}

OAIReverse_response_schema::OAIReverse_response_schema() {
    init();
}

OAIReverse_response_schema::~OAIReverse_response_schema() {
    this->cleanup();
}

void
OAIReverse_response_schema::init() {
    status = new QString("");
    m_status_isSet = false;
    balance = 0L;
    m_balance_isSet = false;
    address = new OAIAddress_schema();
    m_address_isSet = false;
}

void
OAIReverse_response_schema::cleanup() {
    if(status != nullptr) { 
        delete status;
    }

    if(address != nullptr) { 
        delete address;
    }
}

OAIReverse_response_schema*
OAIReverse_response_schema::fromJson(QString json) {
    QByteArray array (json.toStdString().c_str());
    QJsonDocument doc = QJsonDocument::fromJson(array);
    QJsonObject jsonObject = doc.object();
    this->fromJsonObject(jsonObject);
    return this;
}

void
OAIReverse_response_schema::fromJsonObject(QJsonObject pJson) {
    ::OpenAPI::setValue(&status, pJson["status"], "QString", "QString");
    
    ::OpenAPI::setValue(&balance, pJson["balance"], "qint64", "");
    
    ::OpenAPI::setValue(&address, pJson["address"], "OAIAddress_schema", "OAIAddress_schema");
    
}

QString
OAIReverse_response_schema::asJson ()
{
    QJsonObject obj = this->asJsonObject();
    QJsonDocument doc(obj);
    QByteArray bytes = doc.toJson();
    return QString(bytes);
}

QJsonObject
OAIReverse_response_schema::asJsonObject() {
    QJsonObject obj;
    if(status != nullptr && *status != QString("")){
        toJsonValue(QString("status"), status, obj, QString("QString"));
    }
    if(m_balance_isSet){
        obj.insert("balance", QJsonValue(balance));
    }
    if((address != nullptr) && (address->isSet())){
        toJsonValue(QString("address"), address, obj, QString("OAIAddress_schema"));
    }

    return obj;
}

QString*
OAIReverse_response_schema::getStatus() {
    return status;
}
void
OAIReverse_response_schema::setStatus(QString* status) {
    this->status = status;
    this->m_status_isSet = true;
}

qint64
OAIReverse_response_schema::getBalance() {
    return balance;
}
void
OAIReverse_response_schema::setBalance(qint64 balance) {
    this->balance = balance;
    this->m_balance_isSet = true;
}

OAIAddress_schema*
OAIReverse_response_schema::getAddress() {
    return address;
}
void
OAIReverse_response_schema::setAddress(OAIAddress_schema* address) {
    this->address = address;
    this->m_address_isSet = true;
}


bool
OAIReverse_response_schema::isSet(){
    bool isObjectUpdated = false;
    do{
        if(status != nullptr && *status != QString("")){ isObjectUpdated = true; break;}
        if(m_balance_isSet){ isObjectUpdated = true; break;}
        if(address != nullptr && address->isSet()){ isObjectUpdated = true; break;}
    }while(false);
    return isObjectUpdated;
}
}
