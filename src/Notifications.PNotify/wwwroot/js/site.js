

$(function () {
    alert("ddd");
    $("#msgs li").each(function () {
        var classe = $(this).data("classe");
        var text = $(this).text().trim();    
       
        showStackTopCenter(classe, text);             
    }); 
    
});

function showStackTopCenter(type, text_) {
    
    if (typeof window.stackTopCenter === 'undefined') {
        window.stackTopCenter = {
            'dir1': 'down',
            'firstpos1': 50
        };
    }
    var opts = {
        type: type,
        text: text_,
        stack: window.stackTopCenter,
        closer: true,
        history: false,
        styling: "bootstrap3",     
        icons: 'bootstrap3'
    };
    //PNotify.icons = {
    //    brighttheme: {
    //        notice: 'brighttheme-icon-notice',
    //        info: 'brighttheme-icon-info',
    //        success: 'brighttheme-icon-success',
    //        error: 'brighttheme-icon-error'
    //    },
    //    bootstrap3: {
    //        notice: 'glyphicon glyphicon-exclamation-sign',
    //        info: 'glyphicon glyphicon-info-sign',
    //        success: 'glyphicon glyphicon-ok-sign',
    //        error: 'glyphicon glyphicon-warning-sign'
    //    },
    //    // User must have Font Awesome v4.0+
    //    fontawesome4: {
    //        notice: 'fa fa-exclamation-circle',
    //        info: 'fa fa-info-circle',
    //        success: 'fa fa-check-circle',
    //        error: 'fa fa-exclamation-triangle'
    //    },
    //    // User must have Font Awesome v5.0+
    //    fontawesome5: {
    //        notice: 'fas fa-exclamation-circle',
    //        info: 'fas fa-info-circle',
    //        success: 'fas fa-check-circle',
    //        error: 'fas fa-exclamation-triangle'
    //    }
    //};
    PNotify.alert(opts);
}




