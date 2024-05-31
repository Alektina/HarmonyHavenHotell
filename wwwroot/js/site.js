// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

function addToCart(productId) {
    $.ajax({
        url: '/Carts/AddToCart/' + productId,
        type: 'POST',
        success: function () {
            // Show the popup
            $('#cart-popup').show();
            // Hide the popup after a few seconds
            setTimeout(function () {
                $('#cart-popup').hide();
            }, 2000);
            // Update the cart icon
            updateCartIcon();
        },
        error: function (xhr, status, error) {
            console.error(error);
        }
    });
}

function updateCartIcon() {
    $.ajax({
        url: '/Carts/GetCartItemCount',
        type: 'GET',
        success: function (response) {
            // Update the cart icon with the number of items in the cart
            $('#cart-item-count').text(response);
        },
        error: function (xhr, status, error) {
            console.error(error);
        }
    });
    $(document).ready(function () {
        updateCartIcon();
    });