
function vCampos(el, er) {
    var e = $(el).val().replace(er, '');

    $(el).val(e);
}

function num(el) {
    vCampos(el, /[^0-9]/g);
}

function maskCep(el, event) {

    vCampos(el, /[^0-9\-]/g);

    event = event || window.event //For IE

    var e = $(el).val();    

    if (event.keyCode != 8) {

        if (e.length == 5) {
            $(el).val(e + '-');
        }
    }
}

function maskCepBlur(el) {

    vCampos(el, /[^0-9\-]/g);

    var e = $(el).val();

    if (e.length == 8) {
        $(el).val(e.substring(0, 5) + '-' + e.substring(5, 8));
    }
}

function maskData(el, event) {

    vCampos(el, /[^0-9\/]/g);

    event = event || window.event //For IE

    var e = $(el).val();

    if (event.keyCode != 8) {

        if (e.length == 2) {
            $(el).val(e + '/');
        }

        if (e.length == 5) {
            $(el).val(e + '/');
        }
    }
}

// Novo método para o objeto 'String'
String.prototype.reverse = function () {
    return this.split('').reverse().join('');
};

//datepicker
$(document).ready(function () {    
    $('.datepicker').datepicker({        
        dateFormat: 'dd/mm/yy',       
        autoclose: true,
        monthNamesShort: ["Jan", "Fev", "Mar", "Abr", "Mai", "Jun", "Jul", "Ago", "Set", "Out", "Nov", "Dez"],
        monthNames: ["Janeiro", "Fevereiro", "Março", "Abril", "Maio", "Junho", "Julho", "Agosto", "Setembro", "Outubro", "Novembro", "Dezembro"],
        dayNames: ["Domingo", "Segunda-Feira", "Terça-Feira", "Quarta-Feira", "Quinta-Feira", "Sexta-Feira", "Sabado", "Domingo"],
        dayNamesShort: ["Dom", "Seg", "Ter", "Qua", "Qui", "Sex", "Sab", "Dom"],
        dayNamesMin: ["Dom", "Seg", "Ter", "Qua", "Qui", "Sex", "Sab", "Dom"],
        today: ["Hoje"],
        changeMonth: true,
        changeYear: true,
        yearRange: "-150:+0"
    });           
});

