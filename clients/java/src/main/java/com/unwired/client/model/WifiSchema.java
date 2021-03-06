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


package com.unwired.client.model;

import java.util.Objects;
import java.util.Arrays;
import com.google.gson.TypeAdapter;
import com.google.gson.annotations.JsonAdapter;
import com.google.gson.annotations.SerializedName;
import com.google.gson.stream.JsonReader;
import com.google.gson.stream.JsonWriter;
import io.swagger.annotations.ApiModel;
import io.swagger.annotations.ApiModelProperty;
import java.io.IOException;

/**
 * You can send a minimum of 2 and a maximum of 15 WiFi objects in 1 request. If WiFi is not available, wifi object can be omitted all together. In accordance with our industry’s privacy standards we require a minimum of 2 valid nearby Access Points to be sent. If your use-case allows only 1 AP, reach out to us.
 */
@ApiModel(description = "You can send a minimum of 2 and a maximum of 15 WiFi objects in 1 request. If WiFi is not available, wifi object can be omitted all together. In accordance with our industry’s privacy standards we require a minimum of 2 valid nearby Access Points to be sent. If your use-case allows only 1 AP, reach out to us.")

public class WifiSchema {
  public static final String SERIALIZED_NAME_BSSID = "bssid";
  @SerializedName(SERIALIZED_NAME_BSSID)
  private String bssid;

  public static final String SERIALIZED_NAME_CHANNEL = "channel";
  @SerializedName(SERIALIZED_NAME_CHANNEL)
  private Long channel;

  public static final String SERIALIZED_NAME_FREQUENCY = "frequency";
  @SerializedName(SERIALIZED_NAME_FREQUENCY)
  private Long frequency;

  public static final String SERIALIZED_NAME_SIGNAL = "signal";
  @SerializedName(SERIALIZED_NAME_SIGNAL)
  private Long signal;

  public static final String SERIALIZED_NAME_SIGNAL_TO_NOISE_RATIO = "signalToNoiseRatio";
  @SerializedName(SERIALIZED_NAME_SIGNAL_TO_NOISE_RATIO)
  private Long signalToNoiseRatio;

  public WifiSchema bssid(String bssid) {
    this.bssid = bssid;
    return this;
  }

   /**
   * Basic Service Set Identifier or MAC address of the Access Point. Typical format of a MAC address is xx-xx-xx-xx-xx-xx. However, the delimiter can be any of these when sent to the API: : or - or .
   * @return bssid
  **/
  @ApiModelProperty(example = "00:17:c5:cd:ca:aa", value = "Basic Service Set Identifier or MAC address of the Access Point. Typical format of a MAC address is xx-xx-xx-xx-xx-xx. However, the delimiter can be any of these when sent to the API: : or - or .")
  public String getBssid() {
    return bssid;
  }

  public void setBssid(String bssid) {
    this.bssid = bssid;
  }

  public WifiSchema channel(Long channel) {
    this.channel = channel;
    return this;
  }

   /**
   * Channel the WiFi network is operating in (optional)
   * @return channel
  **/
  @ApiModelProperty(example = "11", value = "Channel the WiFi network is operating in (optional)")
  public Long getChannel() {
    return channel;
  }

  public void setChannel(Long channel) {
    this.channel = channel;
  }

  public WifiSchema frequency(Long frequency) {
    this.frequency = frequency;
    return this;
  }

   /**
   * Frequency the WiFi network is operating in (MHz) (optional)
   * @return frequency
  **/
  @ApiModelProperty(example = "2412", value = "Frequency the WiFi network is operating in (MHz) (optional)")
  public Long getFrequency() {
    return frequency;
  }

  public void setFrequency(Long frequency) {
    this.frequency = frequency;
  }

  public WifiSchema signal(Long signal) {
    this.signal = signal;
    return this;
  }

   /**
   * Signal Strength (RSSI)
   * minimum: -121
   * maximum: -25
   * @return signal
  **/
  @ApiModelProperty(example = "-51", value = "Signal Strength (RSSI)")
  public Long getSignal() {
    return signal;
  }

  public void setSignal(Long signal) {
    this.signal = signal;
  }

  public WifiSchema signalToNoiseRatio(Long signalToNoiseRatio) {
    this.signalToNoiseRatio = signalToNoiseRatio;
    return this;
  }

   /**
   * The current signal to noise ratio, measured in dB (optional)
   * @return signalToNoiseRatio
  **/
  @ApiModelProperty(example = "1", value = "The current signal to noise ratio, measured in dB (optional)")
  public Long getSignalToNoiseRatio() {
    return signalToNoiseRatio;
  }

  public void setSignalToNoiseRatio(Long signalToNoiseRatio) {
    this.signalToNoiseRatio = signalToNoiseRatio;
  }


  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    WifiSchema wifiSchema = (WifiSchema) o;
    return Objects.equals(this.bssid, wifiSchema.bssid) &&
        Objects.equals(this.channel, wifiSchema.channel) &&
        Objects.equals(this.frequency, wifiSchema.frequency) &&
        Objects.equals(this.signal, wifiSchema.signal) &&
        Objects.equals(this.signalToNoiseRatio, wifiSchema.signalToNoiseRatio);
  }

  @Override
  public int hashCode() {
    return Objects.hash(bssid, channel, frequency, signal, signalToNoiseRatio);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class WifiSchema {\n");
    
    sb.append("    bssid: ").append(toIndentedString(bssid)).append("\n");
    sb.append("    channel: ").append(toIndentedString(channel)).append("\n");
    sb.append("    frequency: ").append(toIndentedString(frequency)).append("\n");
    sb.append("    signal: ").append(toIndentedString(signal)).append("\n");
    sb.append("    signalToNoiseRatio: ").append(toIndentedString(signalToNoiseRatio)).append("\n");
    sb.append("}");
    return sb.toString();
  }

  /**
   * Convert the given object to string with each line indented by 4 spaces
   * (except the first line).
   */
  private String toIndentedString(java.lang.Object o) {
    if (o == null) {
      return "null";
    }
    return o.toString().replace("\n", "\n    ");
  }

}

