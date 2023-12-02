//Account Type Selection in Reg and Login Pages
$(document).ready(function () {
    $('input[name="accountType"]').change(function () {
        var selectedAccountType = $(this).val();

        if (selectedAccountType === 'user') {
            $('#companyAccountFields').hide();
            $('#userAccountFields').show();
        } else if (selectedAccountType === 'company') {
            $('#userAccountFields').hide();
            $('#companyAccountFields').show();
        }
    });
});

//Show Password using a checkbox
$(document).ready(function () {
    $('.show-password-toggle').change(function () {
        var passwordField = $(this).closest('.input-group').find('.password-field');
        var isChecked = $(this).is(':checked');
        if (isChecked) {
            passwordField.attr('type', 'text');
        } else {
            passwordField.attr('type', 'password');
        }
    });
});
