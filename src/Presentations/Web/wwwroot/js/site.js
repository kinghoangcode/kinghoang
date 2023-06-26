// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

const kingPopup = '.king-popup';

$(function () {

    $('.coffee-order-btn').click(function () {
        popupShow('#form-order-popup', () => {
            $('#fullname').focus();
        });
    });

    $('.coffee-send-order-btn').click(function () {
        popupHide('#form-order-popup', () => {
            popupShow('#order-success-popup');
        });
    });

    $(document).on('click', '.popup-backdrop', () => {
        popupHide(kingPopup);
    });

    $(document).on('click', '.order-success-close', (element) => {
        const currentPopup = $(element.target).parents(kingPopup).attr('id');
        popupHide(`#${currentPopup}`);
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
    $(popupId).each((index, element) => {
        if ($(element).hasClass('popup-show')) {
            $(element).removeClass('popup-show').addClass('popup-hide');
        }
    })

    setTimeout(() => {
        $(popupId).removeClass('popup-hide');
    }, 400);

    $('body').find('.popup-backdrop').remove();

    if (callback) {
        callback();
    }
};
