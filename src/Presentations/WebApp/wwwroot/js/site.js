// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

$(function () {

    $('.coffee-order-btn').click(function () {
        popupShow('#form-order-popup', () => {
            $('#fullname').focus();
        });
    });

    $('.coffee-submit-btn').click(function () {
        popupHide('#form-order-popup');
    });

    $(document).on('click', '.popup-backdrop', () => {
        popupHide('.king-popup');
    });
})

const popupShow = (popupId, callback = null) => {
    $(popupId).removeClass('popup-hide').addClass('popup-show');

    $('body').append('<div class="popup-backdrop"></div>');

    if (callback) {
        callback();
    }
};


const popupHide = (popupId, callback = null) => {
    $(popupId).removeClass('popup-show').addClass('popup-hide');
    setTimeout(() => {
        $(popupId).removeClass('popup-hide');
    }, 400);

    $('body').find('.popup-backdrop').remove();

    if (callback) {
        callback();
    }
};
