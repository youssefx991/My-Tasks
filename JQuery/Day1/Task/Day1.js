
let curr_img = 1;
let name;
let email;
let phone;
let complain;
let is_slided = false;
$(document).ready(function () {
    $(".card_about").click(function () {
        $(".content1").css("display", "block");
        $(".content2").css("display", "none");
        $(".content3").css("display", "none");
        $(".content4").css("display", "none");
        $(".content5").css("display", "none");
        is_slided = false;

    });

    $(".card_gallery").click(function () {
        $(".content1").css("display", "none");
        $(".content2").css("display", "block");
        $(".content3").css("display", "none");
        $(".content4").css("display", "none");
        $(".content5").css("display", "none");
        is_slided = false;

    });

    $(".card_complain").click(function () {
        $('#name').val('');
        $('#email').val('');
        $('#phone').val('');
        $('#complain_textarea').val('');
        $(".content1").css("display", "none");
        $(".content2").css("display", "none");
        $(".content3").css("display", "none");
        $(".content4").css("display", "block");
        $(".content5").css("display", "none");
        is_slided = false;

    });

    $('#left').click(function () {
        curr_img = (curr_img - 1 + 8) % 8;
        $('#mid').attr('src', '' + (curr_img + 1) + '.jpg');
        
    });
    $('#right').click(function () {
        curr_img = (curr_img + 1) % 8;
        $('#mid').attr('src', '' + (curr_img + 1) + '.jpg');
    });
    
    $(".card_services").click(function(){
        $(".content1").css("display", "none");
        $(".content2").css("display", "none");
        $(".content4").css("display", "none");
        $(".content5").css("display", "none");
        if (is_slided)
            $(".content3").slideUp("slow");
        else 
            $(".content3").slideDown("slow");
        is_slided = ! is_slided;
    });

    $('#send').click(function () {
        name = $('#name').val();
        email = $('#email').val();
        phone = $('#phone').val();
        complain = $('#complain_textarea').val();

        if (name === "" || email === "" || phone === "" || complain === "") {
            alert("Please fill all the fields.");
        } else {
            $(".content1").css("display", "none");
            $(".content2").css("display", "none");
            $(".content3").css("display", "none");
            $(".content4").css("display", "none");
            $(".content5").css("display", "block");
            $('#comp_name').text(name);
            $('#comp_email').text(email);
            $('#comp_phone').text(phone);
            $('#comp_complain').text(complain);
        }
    });

    $('#back').click(function () {
        $(".content1").css("display", "none");
        $(".content2").css("display", "none");
        $(".content3").css("display", "none");
        $(".content4").css("display", "block");
        $(".content5").css("display", "none");
    });
});
