# coding: utf-8

"""
    Location API

    Geolocation, Geocoding and Maps  # noqa: E501

    OpenAPI spec version: 2.0.0
    Generated by: https://openapi-generator.tech
"""


import pprint
import re  # noqa: F401

import six


class CellSchema(object):
    """NOTE: This class is auto generated by OpenAPI Generator.
    Ref: https://openapi-generator.tech

    Do not edit the class manually.
    """

    """
    Attributes:
      openapi_types (dict): The key is attribute name
                            and the value is attribute type.
      attribute_map (dict): The key is attribute name
                            and the value is json key in definition.
    """
    openapi_types = {
        'lac': 'int',
        'cid': 'int',
        'radio': 'RadioSchema',
        'mcc': 'int',
        'mnc': 'int',
        'signal': 'int',
        'psc': 'int',
        'asu': 'int',
        'ta': 'int'
    }

    attribute_map = {
        'lac': 'lac',
        'cid': 'cid',
        'radio': 'radio',
        'mcc': 'mcc',
        'mnc': 'mnc',
        'signal': 'signal',
        'psc': 'psc',
        'asu': 'asu',
        'ta': 'ta'
    }

    def __init__(self, lac=None, cid=None, radio=None, mcc=None, mnc=None, signal=None, psc=None, asu=None, ta=None):  # noqa: E501
        """CellSchema - a model defined in OpenAPI"""  # noqa: E501

        self._lac = None
        self._cid = None
        self._radio = None
        self._mcc = None
        self._mnc = None
        self._signal = None
        self._psc = None
        self._asu = None
        self._ta = None
        self.discriminator = None

        if lac is not None:
            self.lac = lac
        if cid is not None:
            self.cid = cid
        if radio is not None:
            self.radio = radio
        if mcc is not None:
            self.mcc = mcc
        if mnc is not None:
            self.mnc = mnc
        if signal is not None:
            self.signal = signal
        if psc is not None:
            self.psc = psc
        if asu is not None:
            self.asu = asu
        if ta is not None:
            self.ta = ta

    @property
    def lac(self):
        """Gets the lac of this CellSchema.  # noqa: E501

        the Location Area Code of your operator’s network.  # noqa: E501

        :return: The lac of this CellSchema.  # noqa: E501
        :rtype: int
        """
        return self._lac

    @lac.setter
    def lac(self, lac):
        """Sets the lac of this CellSchema.

        the Location Area Code of your operator’s network.  # noqa: E501

        :param lac: The lac of this CellSchema.  # noqa: E501
        :type: int
        """
        if lac is not None and lac > 65533:  # noqa: E501
            raise ValueError("Invalid value for `lac`, must be a value less than or equal to `65533`")  # noqa: E501
        if lac is not None and lac < 1:  # noqa: E501
            raise ValueError("Invalid value for `lac`, must be a value greater than or equal to `1`")  # noqa: E501

        self._lac = lac

    @property
    def cid(self):
        """Gets the cid of this CellSchema.  # noqa: E501

        Cell ID  # noqa: E501

        :return: The cid of this CellSchema.  # noqa: E501
        :rtype: int
        """
        return self._cid

    @cid.setter
    def cid(self, cid):
        """Sets the cid of this CellSchema.

        Cell ID  # noqa: E501

        :param cid: The cid of this CellSchema.  # noqa: E501
        :type: int
        """
        if cid is not None and cid > 268435455:  # noqa: E501
            raise ValueError("Invalid value for `cid`, must be a value less than or equal to `268435455`")  # noqa: E501
        if cid is not None and cid < 0:  # noqa: E501
            raise ValueError("Invalid value for `cid`, must be a value greater than or equal to `0`")  # noqa: E501

        self._cid = cid

    @property
    def radio(self):
        """Gets the radio of this CellSchema.  # noqa: E501


        :return: The radio of this CellSchema.  # noqa: E501
        :rtype: RadioSchema
        """
        return self._radio

    @radio.setter
    def radio(self, radio):
        """Sets the radio of this CellSchema.


        :param radio: The radio of this CellSchema.  # noqa: E501
        :type: RadioSchema
        """

        self._radio = radio

    @property
    def mcc(self):
        """Gets the mcc of this CellSchema.  # noqa: E501

        \"Mobile Country Code of your operator’s network represented by an integer (Optional). Range: 0 to 999.\"  # noqa: E501

        :return: The mcc of this CellSchema.  # noqa: E501
        :rtype: int
        """
        return self._mcc

    @mcc.setter
    def mcc(self, mcc):
        """Sets the mcc of this CellSchema.

        \"Mobile Country Code of your operator’s network represented by an integer (Optional). Range: 0 to 999.\"  # noqa: E501

        :param mcc: The mcc of this CellSchema.  # noqa: E501
        :type: int
        """

        self._mcc = mcc

    @property
    def mnc(self):
        """Gets the mnc of this CellSchema.  # noqa: E501

        Mobile Network Code of your operator’s network represented by an integer (Optional). Range: 0 to 999. On CDMA, provide the System ID or SID, with range: 1 to 32767.  # noqa: E501

        :return: The mnc of this CellSchema.  # noqa: E501
        :rtype: int
        """
        return self._mnc

    @mnc.setter
    def mnc(self, mnc):
        """Sets the mnc of this CellSchema.

        Mobile Network Code of your operator’s network represented by an integer (Optional). Range: 0 to 999. On CDMA, provide the System ID or SID, with range: 1 to 32767.  # noqa: E501

        :param mnc: The mnc of this CellSchema.  # noqa: E501
        :type: int
        """

        self._mnc = mnc

    @property
    def signal(self):
        """Gets the signal of this CellSchema.  # noqa: E501

        Signal Strength (RSSI)  # noqa: E501

        :return: The signal of this CellSchema.  # noqa: E501
        :rtype: int
        """
        return self._signal

    @signal.setter
    def signal(self, signal):
        """Sets the signal of this CellSchema.

        Signal Strength (RSSI)  # noqa: E501

        :param signal: The signal of this CellSchema.  # noqa: E501
        :type: int
        """
        if signal is not None and signal > -25:  # noqa: E501
            raise ValueError("Invalid value for `signal`, must be a value less than or equal to `-25`")  # noqa: E501
        if signal is not None and signal < -121:  # noqa: E501
            raise ValueError("Invalid value for `signal`, must be a value greater than or equal to `-121`")  # noqa: E501

        self._signal = signal

    @property
    def psc(self):
        """Gets the psc of this CellSchema.  # noqa: E501

        Primary Scrambling Code  # noqa: E501

        :return: The psc of this CellSchema.  # noqa: E501
        :rtype: int
        """
        return self._psc

    @psc.setter
    def psc(self, psc):
        """Sets the psc of this CellSchema.

        Primary Scrambling Code  # noqa: E501

        :param psc: The psc of this CellSchema.  # noqa: E501
        :type: int
        """
        if psc is not None and psc > 503:  # noqa: E501
            raise ValueError("Invalid value for `psc`, must be a value less than or equal to `503`")  # noqa: E501
        if psc is not None and psc < 0:  # noqa: E501
            raise ValueError("Invalid value for `psc`, must be a value greater than or equal to `0`")  # noqa: E501

        self._psc = psc

    @property
    def asu(self):
        """Gets the asu of this CellSchema.  # noqa: E501

        Arbitrary Strength Unit  # noqa: E501

        :return: The asu of this CellSchema.  # noqa: E501
        :rtype: int
        """
        return self._asu

    @asu.setter
    def asu(self, asu):
        """Sets the asu of this CellSchema.

        Arbitrary Strength Unit  # noqa: E501

        :param asu: The asu of this CellSchema.  # noqa: E501
        :type: int
        """
        if asu is not None and asu > 97:  # noqa: E501
            raise ValueError("Invalid value for `asu`, must be a value less than or equal to `97`")  # noqa: E501
        if asu is not None and asu < -5:  # noqa: E501
            raise ValueError("Invalid value for `asu`, must be a value greater than or equal to `-5`")  # noqa: E501

        self._asu = asu

    @property
    def ta(self):
        """Gets the ta of this CellSchema.  # noqa: E501

        Timing Advance  # noqa: E501

        :return: The ta of this CellSchema.  # noqa: E501
        :rtype: int
        """
        return self._ta

    @ta.setter
    def ta(self, ta):
        """Sets the ta of this CellSchema.

        Timing Advance  # noqa: E501

        :param ta: The ta of this CellSchema.  # noqa: E501
        :type: int
        """
        if ta is not None and ta > 63:  # noqa: E501
            raise ValueError("Invalid value for `ta`, must be a value less than or equal to `63`")  # noqa: E501
        if ta is not None and ta < 0:  # noqa: E501
            raise ValueError("Invalid value for `ta`, must be a value greater than or equal to `0`")  # noqa: E501

        self._ta = ta

    def to_dict(self):
        """Returns the model properties as a dict"""
        result = {}

        for attr, _ in six.iteritems(self.openapi_types):
            value = getattr(self, attr)
            if isinstance(value, list):
                result[attr] = list(map(
                    lambda x: x.to_dict() if hasattr(x, "to_dict") else x,
                    value
                ))
            elif hasattr(value, "to_dict"):
                result[attr] = value.to_dict()
            elif isinstance(value, dict):
                result[attr] = dict(map(
                    lambda item: (item[0], item[1].to_dict())
                    if hasattr(item[1], "to_dict") else item,
                    value.items()
                ))
            else:
                result[attr] = value

        return result

    def to_str(self):
        """Returns the string representation of the model"""
        return pprint.pformat(self.to_dict())

    def __repr__(self):
        """For `print` and `pprint`"""
        return self.to_str()

    def __eq__(self, other):
        """Returns true if both objects are equal"""
        if not isinstance(other, CellSchema):
            return False

        return self.__dict__ == other.__dict__

    def __ne__(self, other):
        """Returns true if both objects are not equal"""
        return not self == other