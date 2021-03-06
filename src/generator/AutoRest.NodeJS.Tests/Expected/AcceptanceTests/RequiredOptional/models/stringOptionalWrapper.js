/*
 * Copyright (c) Microsoft Corporation. All rights reserved.
 * Licensed under the MIT License. See License.txt in the project root for
 * license information.
 *
 * Code generated by Microsoft (R) AutoRest Code Generator.
 * Changes may cause incorrect behavior and will be lost if the code is
 * regenerated.
 */

'use strict';

/**
 * @class
 * Initializes a new instance of the StringOptionalWrapper class.
 * @constructor
 * @member {string} [value]
 *
 */
function StringOptionalWrapper() {
}

/**
 * Defines the metadata of StringOptionalWrapper
 *
 * @returns {object} metadata of StringOptionalWrapper
 *
 */
StringOptionalWrapper.prototype.mapper = function () {
  return {
    required: false,
    serializedName: 'string-optional-wrapper',
    type: {
      name: 'Composite',
      className: 'StringOptionalWrapper',
      modelProperties: {
        value: {
          required: false,
          serializedName: 'value',
          type: {
            name: 'String'
          }
        }
      }
    }
  };
};

module.exports = StringOptionalWrapper;
