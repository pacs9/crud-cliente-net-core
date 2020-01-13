
function vCampos(el, er) {
    var e = $(el).val().replace(er, '');

    $(el).val(e);
}

function num(el) {
    vCampos(el, /[^0-9]/g);
}

function maskFone(el, event) {
    vCampos(el, /[^0-9\-\)\(\ ]/g);

    event = event || window.event //For IE

    var e = $(el).val();

    if (event.keyCode != 8) {
        if (e.length == 1) {
            $(el).val('(' + e);
        }

        if (e.length == 3) {
            $(el).val(e + ') ');
        }

        if (e.length == 9) {
            $(el).val(e + '-');
        }

        if (e.replace(' ', '').replace(' ', '').length == 15) {
            $(el).val(e.substring(0, 6) + ' ' +
                e.replace('-', '').substring(6, 10) + '-' +
                e.substring(11, 15));
        }
    }
}

function maskFoneValidaBlur(el) {
    
    vCampos(el, /[^0-9]/g);

    var e = $(el).val();
    
    if (e.length == 10) {
        el.pattern = '\\([0-9]{2}\\) [0-9]{4,6}-[0-9]{3,4}$';

        $(el).val('(' + e.substring(0, 2) + ') ' +
            e.substring(2, 6) + '-' + e.substring(6, 10));
    }
    
    if (e.length == 11) {
        el.pattern = '\\([0-9]{2}\\) [0-9]{0,1} [0-9]{4,6}-[0-9]{3,4}$';

        $(el).val('(' + e.substring(0, 2) + ') ' + e.substring(2, 3) + ' ' +
            e.substring(3, 7) + '-' + e.substring(7, 11));
    }
}

function maskCpfBlur(el, event) {

    vCampos(el, /[^0-9]/g);    

    var e = $(el).val();    
    
    if (e.length == 11) {
        $(el).val(e.substring(0, 3) + '.' + e.substring(3, 6) + '.' + e.substring(6, 9) + '-' + e.substring(9, 11));
    }    
}

function maskCpf(el, event) {

    vCampos(el, /[^0-9\.\-]/g);

    event = event || window.event //For IE

    var e = $(el).val();

    if (event.keyCode != 8) {

        if (e.length == 3) {
            $(el).val(e + '.');
        }

        if (e.length == 7) {
            $(el).val(e + '.');
        }

        if (e.length == 11) {
            $(el).val(e + '-');
        }
    }
}

function maskCnpjBlur(el, event) {

    vCampos(el, /[^0-9]/g);

    var e = $(el).val();

    if (e.length == 14) {
        $(el).val(e.substring(0, 2) + '.' + e.substring(2, 5) + '.' + e.substring(5, 8) + '/' + e.substring(8, 12) + '-' + e.substring(12, 14));
    }
}

function maskCnpj(el, event) {

    vCampos(el, /[^0-9\.\/\-]/g);

    event = event || window.event //For IE

    var e = $(el).val();

    if (event.keyCode != 8) {

        if (e.length == 2) {
            $(el).val(e + '.');
        }

        if (e.length == 6) {
            $(el).val(e + '.');
        }

        if (e.length == 10) {
            $(el).val(e + '/');
        }

        if (e.length == 15) {
            $(el).val(e + '-');
        }
    }
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

function maskDataHora(el, event) {    

    vCampos(el, /[^0-9\:\/)\(\ ]/g);

    event = event || window.event //For IE

    var e = $(el).val();

    if (event.keyCode != 8) {

        if (e.length == 2) {
            $(el).val(e + '/');
        }

        if (e.length == 5) {
            $(el).val(e + '/');
        }

        if (e.length == 10) {
            $(el).val(e + ' ');
        }

        if (e.length == 13) {
            $(el).val(e + ':');
        }
    }
} 

function maskMoeda(w, e, a) {

    var m = '#########,##';
    var r = true;

    // Cancela se o evento for Backspace
    if (!e) var e = window.event
    if (e.keyCode) code = e.keyCode;
    else if (e.which) code = e.which;
    // Variáveis da função
    var txt = (!r) ? w.value.replace(/[^\d]+/gi, '') : w.value.replace(/[^\d]+/gi, '').reverse();
    var mask = (!r) ? m : m.reverse();
    var pre = (a) ? a.pre : "";
    var pos = (a) ? a.pos : "";
    var ret = "";
    //if (code == 9 || code == 8 || txt.length == mask.replace(/[^#]+/g, '').length) return false;
    if (code == 9 || txt.length == mask.replace(/[^#]+/g, '').length) return false;
    // Loop na máscara para aplicar os caracteres
    for (var x = 0, y = 0, z = mask.length; x < z && y < txt.length;) {
        if (mask.charAt(x) != '#') {
            ret += mask.charAt(x); x++;
        }
        else {
            ret += txt.charAt(y); y++; x++;
        }
    }
    // Retorno da função
    ret = (!r) ? ret : ret.reverse();
    w.value = pre + ret + pos;    
}
// Novo método para o objeto 'String'
String.prototype.reverse = function () {
    return this.split('').reverse().join('');
};

//datepicker
$(document).ready(function () {    
    $('.datepicker').datepicker({
        format: 'dd/mm/yyyy',        
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

