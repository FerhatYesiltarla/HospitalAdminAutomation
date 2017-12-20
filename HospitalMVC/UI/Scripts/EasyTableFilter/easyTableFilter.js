var btnID = null;

$('.btnList').click(function (e) {
    btnID = $(this).attr('id');
    $('.popover__content').css('left', $('#' + btnID)[0].getBoundingClientRect().left + $('#' + btnID).width());
    $('.popover__content').css('top', $('#' + btnID)[0].getBoundingClientRect().top + $('#' + btnID).height() / 2);
    $('.popover__content').fadeIn("fast"); 
});

$('#close').click(function () {
    popUpDismiss();
});

$(window).on('scroll', function () {
    $('.popover__content').css('left', $('#' + btnID)[0].getBoundingClientRect().left + $('#' + btnID).width());
    $('.popover__content').css('top', $('#' + btnID)[0].getBoundingClientRect().top + +$('#' + btnID).height() / 2);
});

$(window).on('click', function (event) {
    if (event.target.id == modal.attr('id')) {
        modal.css({ 'display': 'none' });
    }
});

function popUpDismiss() {
    if ($('.popover__content').is(':visible')) {
        $('.popover__content').fadeOut("slow");
    }
}