// Declare our namspace
var Blazority = Blazority || {};

/**
 * Set focus on specified element
 * @param {any} selector
 */
Blazority.SetElemFocus = function (el) {
    el && el.focus();
};

/**
 * Set focus on specified element by selector
 * @param {any} selector
 */
Blazority.SetFocus = function (selector) {
    if (selector) {
        var el = document.querySelector(selector);
        Blazority.SetElemFocus(el);
    }
};

/**
 * Update property of the specific element
 * @param {any} element 
 * @param {any} property
 * @param {any} value
 */
Blazority.SetElemProperty = function (element, property, value) {
    if (element && property) {
        element[property] = value;
    }
};

/**
 * Clear focus on specified element
 * @param {any} selector
 */
Blazority.ClearElemFocus = function (el) {
    el && el.blur();
};

/**
 * Clear focus on specified element by selector
 * @param {any} selector
 */
Blazority.ClearFocus = function (selector) {
    if (selector) {
        var el = document.querySelector(selector);
        Blazority.ClearElemFocus(el);
    }
};

/**
 * Clear all user selection ranges
 */
Blazority.ClearSelectionRanges = function () {
    var selection = window && window.getSelection();
    selection && selection.removeAllRanges();
};

/**
 * Get bounding rectangle of an element.
 * @param {any} selector
 */
Blazority.GetBoundingClientRect = function (selector) {
    var el = document.querySelector(selector);
    return el && el.getBoundingClientRect();
};


/**
 * Update the range slider.
 * @param {any} inputSelector
 * @param {any} sliderSelector
 */
Blazority.UpdateSlider = function (inputSelector, sliderSelector) {
    if (inputSelector && sliderSelector) {
        var input = document.querySelector(inputSelector);
        var sliderEl = document.querySelector(sliderSelector);
        if (input && sliderEl) {
            var inputWidth = input.offsetWidth;
            var minValue = +input.min;
            var maxValue = +input.max;

            if (minValue === 0 && maxValue === 0) {
                maxValue = 100;
            }

            var middle = (minValue + maxValue) / 2;
            var value = input.value !== undefined ? input.value : middle;
            var valueAsPercent = ((value - minValue) * 100) / (maxValue - minValue);

            sliderEl.style.width = (valueAsPercent * inputWidth) / 100 + 'px'
        }
    }
};