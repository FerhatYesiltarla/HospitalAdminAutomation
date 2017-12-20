function toggleForm() {
    if ($(".loginForm").css("display") == "none") {
        $('#formTitle').html('Giriş yap');
        $('.signInOrOut').html('bir hesap oluşturun');
        $('#signInOrOutMenu').text(' Kayıt ol');
        $(".loginForm").show("slow").siblings(1000);
        $('.signUpForm').hide("slow").siblings(1000);
    }
    else {
        $('#formTitle').html('Kayıt ol');
        $('.signInOrOut').html('hesabınla gir');
        $('#signInOrOutMenu').text(' Giriş yap');
        $(".loginForm").hide("slow").siblings(1000);
        $('.signUpForm').show("slow").siblings(1000);
    }
}