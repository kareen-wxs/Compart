//////function matchStart(params, data) {
//////	params.term = params.term || '';
//////	if (data.text.toUpperCase().indexOf(params.term.toUpperCase()) == 0) {
//////		return data;
//////	}
//////	return false;
//////}

///////* detecting touch device */
//////var supportsTouch = 'ontouchstart' in window || navigator.msMaxTouchPoints;



///////* detecting mobile and low-width device */
//////var isMobile = false, isMobile2 = false, isMobile3 = false, headerfixCat = false; //initiate as false
//////// device detection
//////if (/(android|bb\d+|meego).+mobile|avantgo|bada\/|blackberry|blazer|compal|elaine|fennec|hiptop|iemobile|ip(hone|od)|ipad|iris|kindle|Android|Silk|lge |maemo|midp|mmp|netfront|opera m(ob|in)i|palm( os)?|phone|p(ixi|re)\/|plucker|pocket|psp|series(4|6)0|symbian|treo|up\.(browser|link)|vodafone|wap|windows (ce|phone)|xda|xiino/i.test(navigator.userAgent)
//////	|| /1207|6310|6590|3gso|4thp|50[1-6]i|770s|802s|a wa|abac|ac(er|oo|s\-)|ai(ko|rn)|al(av|ca|co)|amoi|an(ex|ny|yw)|aptu|ar(ch|go)|as(te|us)|attw|au(di|\-m|r |s )|avan|be(ck|ll|nq)|bi(lb|rd)|bl(ac|az)|br(e|v)w|bumb|bw\-(n|u)|c55\/|capi|ccwa|cdm\-|cell|chtm|cldc|cmd\-|co(mp|nd)|craw|da(it|ll|ng)|dbte|dc\-s|devi|dica|dmob|do(c|p)o|ds(12|\-d)|el(49|ai)|em(l2|ul)|er(ic|k0)|esl8|ez([4-7]0|os|wa|ze)|fetc|fly(\-|_)|g1 u|g560|gene|gf\-5|g\-mo|go(\.w|od)|gr(ad|un)|haie|hcit|hd\-(m|p|t)|hei\-|hi(pt|ta)|hp( i|ip)|hs\-c|ht(c(\-| |_|a|g|p|s|t)|tp)|hu(aw|tc)|i\-(20|go|ma)|i230|iac( |\-|\/)|ibro|idea|ig01|ikom|im1k|inno|ipaq|iris|ja(t|v)a|jbro|jemu|jigs|kddi|keji|kgt( |\/)|klon|kpt |kwc\-|kyo(c|k)|le(no|xi)|lg( g|\/(k|l|u)|50|54|\-[a-w])|libw|lynx|m1\-w|m3ga|m50\/|ma(te|ui|xo)|mc(01|21|ca)|m\-cr|me(rc|ri)|mi(o8|oa|ts)|mmef|mo(01|02|bi|de|do|t(\-| |o|v)|zz)|mt(50|p1|v )|mwbp|mywa|n10[0-2]|n20[2-3]|n30(0|2)|n50(0|2|5)|n7(0(0|1)|10)|ne((c|m)\-|on|tf|wf|wg|wt)|nok(6|i)|nzph|o2im|op(ti|wv)|oran|owg1|p800|pan(a|d|t)|pdxg|pg(13|\-([1-8]|c))|phil|pire|pl(ay|uc)|pn\-2|po(ck|rt|se)|prox|psio|pt\-g|qa\-a|qc(07|12|21|32|60|\-[2-7]|i\-)|qtek|r380|r600|raks|rim9|ro(ve|zo)|s55\/|sa(ge|ma|mm|ms|ny|va)|sc(01|h\-|oo|p\-)|sdk\/|se(c(\-|0|1)|47|mc|nd|ri)|sgh\-|shar|sie(\-|m)|sk\-0|sl(45|id)|sm(al|ar|b3|it|t5)|so(ft|ny)|sp(01|h\-|v\-|v )|sy(01|mb)|t2(18|50)|t6(00|10|18)|ta(gt|lk)|tcl\-|tdg\-|tel(i|m)|tim\-|t\-mo|to(pl|sh)|ts(70|m\-|m3|m5)|tx\-9|up(\.b|g1|si)|utst|v400|v750|veri|vi(rg|te)|vk(40|5[0-3]|\-v)|vm40|voda|vulc|vx(52|53|60|61|70|80|81|83|85|98)|w3c(\-| )|webc|whit|wi(g |nc|nw)|wmlb|wonu|x700|yas\-|your|zeto|zte\-/i.test(navigator.userAgent.substr(0, 4))) isMobile = true;

//////function doViewWidth() {
//////	var windowWidth = viewport().width;
//////	if (windowWidth <= 959) {
//////		isMobile2 = true;
//////		if ($('#sideFilter')[0]) {
//////			$('#sideFilter').addClass('collapse');
//////			$('.b-mob-filter-head').addClass('collapsed');
//////		}
//////		if ($('#configPanelFilter')[0]) {
//////			if (!$('#configPanelFilter').hasClass('no-auto-collapse')) {
//////				$('#configPanelFilter').addClass('collapse');
//////				$('.b-mob-filter-head').addClass('collapsed');
//////			}
//////		}
//////	}
//////	else {
//////		isMobile2 = false;
//////		if ($('#sideFilter')[0]) {
//////			$('#sideFilter').removeClass('collapse');
//////			$('.b-mob-filter-head').removeClass('collapsed');
//////		}
//////		if ($('#configPanelFilter')[0]) {
//////			if (!$('#configPanelFilter').hasClass('no-auto-collapse')) {
//////				$('#configPanelFilter').removeClass('collapse');
//////				$('.b-mob-filter-head').removeClass('collapsed');
//////			}
//////		}
//////	}
//////	if (windowWidth <= 720) {
//////		isMobile3 = true;
//////	}
//////	else {
//////		isMobile3 = false;
//////	}
//////}
//////function viewport() {
//////	var e = window, a = 'inner';
//////	if (!('innerWidth' in window)) {
//////		a = 'client';
//////		e = document.documentElement || document.body;
//////	}
//////	return { width: e[a + 'Width'], height: e[a + 'Height'] };
//////}

//////var resizeTimer;
//////$(window).resize(function () {
//////	clearTimeout(resizeTimer);
//////	resizeTimer = setTimeout(doViewWidth, 100);
//////	viewport();
//////});





//////$(document).ready(function () {


//////	Inputmask.extendDefaults({
//////		autoUnmask: true,
//////		showMaskOnHover: true,
//////		showMaskOnFocus: true,
//////		placeholder: "_",
//////		removeMaskOnSubmit: true,
//////		onUnMask: function (masked, unmasked) {
//////			return "0" + unmasked;
//////		},
//////		onBeforeMask: function (value) {

//////			if (value.charAt(0) == "+" && value.charAt(1) == "3" && value.charAt(2) == "8") {
//////				return value.substring(6);
//////			} else if (value.charAt(0) == "0")
//////				return value.substring(1);
//////			// Value is stripped of decimals here!
//////			return value;
//////		}
//////	});

//////	$('.vPhone').inputmask({ "mask": "+38 (099) 999 99 99", "cc": "UA", "cd": "Ukraine", "type": "mobile" });

//////	$('.b-mnp-slider').swiperight(function () {
//////		$(this).carousel('prev');
//////	});
//////	$('.b-mnp-slider').swipeleft(function () {
//////		$(this).carousel('next');
//////	});


//////	$('#simplecar').bind('slide.bs.carousel', function (e) {
//////		var target = $('.b-order-box');
//////		$('html,body').animate({
//////			scrollTop: target.offset().top
//////		}, 500);
//////	});


//////	$('.b-hmb-mobnav-toggler').click(function (e) {
//////		$('#hmbpBasket, #sideFilter').removeClass('in');
//////		$('.b-mob-filter-head, .b-active .b-hmb-link-basket').addClass('collapsed');
//////		e.preventDefault()
//////	});

//////	$('.b-hmb-link-basket').click(function (e) {
//////		$('body').removeClass('c-mobnav-active');
//////		$('#hmbpCatalog, #sideFilter').removeClass('in');
//////		$('.b-mob-filter-head, .b-hmb-mobnav-toggler').addClass('collapsed');
//////		e.preventDefault()
//////	});

//////	$('.b-mob-filter-head').click(function (e) {
//////		if ($('.b-content-action-body').length) {
//////			$('#hmbpBasket, #hmbpCatalog').removeClass('in');
//////			$('.b-active .b-hmb-link-basket,.b-hmb-mobnav-toggler').addClass('collapsed');
//////			e.preventDefault();
//////			/*if ($('body').hasClass('c-mob-filter-open'))
//////			{
//////				$('body').removeClass('c-mob-filter-open');
//////			}
//////			else {
//////				$('body').addClass('c-mob-filter-open');
//////			}*/
//////		}
//////		else {
//////			$('#hmbpBasket, #hmbpCatalog').removeClass('in');
//////			$('.b-active .b-hmb-link-basket,.b-hmb-mobnav-toggler').addClass('collapsed');
//////			e.preventDefault();
//////			if ($('body').hasClass('c-mob-filter-open')) {
//////				$('body').removeClass('c-mob-filter-open');
//////				$('.b-wrap-all').css('height', '100%');
//////			}
//////			else {
//////				$('body').addClass('c-mob-filter-open');
//////			}
//////		}
//////	});

//////	if ($('#sideFilter')[0]) {
//////		var filterHeightBlock = $('.b-wrap-side-filter');
//////	}
//////	if ($('#configPanelFilter')[0]) {
//////		var filterHeightBlock = $('.b-config-wpanel-mob-wrapper');
//////	}


//////	$('.b-side-filter').on('shown.bs.collapse', function () {
//////		if ($('.b-content-action-body').length == 0) {
//////			$('body').addClass('c-mob-filter-open');
//////			var cMFOHeight = $('.b-header').outerHeight() + filterHeightBlock.outerHeight();
//////			$('.b-wrap-all').css('height', cMFOHeight + 'px');
//////		}
//////	});

//////	$('#configPanelFilter').on('shown.bs.collapse', function () {
//////		if ($('.b-content-action-body').length) {
//////			$('body').addClass('c-mob-filter-open');
//////			var cMFOHeight = $('.b-header').outerHeight() + filterHeightBlock.outerHeight();
//////			$('.b-wrap-all').css('height', cMFOHeight + 'px');
//////		}
//////	});




//////	/* configurator mobile only collapse */
//////	$('.b-cwp-bsc-container .b-head[data-toggle="collapse"]').click(function (e) {
//////		if ($(window).width() >= 959) {
//////			e.preventDefault();
//////			e.stopPropagation();
//////		}
//////	});

//////	var $win;

//////	// Function toggles bootstrap collapse based on window width.
//////	function toggleCollapse($win) {
//////		// Small screens
//////		if ($win.width() < 960) {
//////			$('.b-dont-collapse-pc.collapse').collapse('hide');
//////		}
//////		if ($win.width() >= 960) {
//////			$('.b-dont-collapse-pc.collapse').collapse('show');
//////		}
//////	}

//////	// Set collapsible appearance on window load;
//////	toggleCollapse($(window));

//////	// Toggle collapsibles on resize. Optional if you want
//////	// to be able to show/hide on window resize.
//////	$(window).on('resize', function () {
//////		var $win = $(this);
//////		toggleCollapse($win);
//////	});




//////	/*.on('show.bs.collapse', function() {
//////	console.log('show');
//////});*/

//////	/*
//////	$('.b-btn-go-next').click(function(){ //, .b-order-box-slider-item .b-btn-checkout
//////		$("#simplecar").carousel('next');
//////		return false;
//////	});
//////	$('.b-btn-go-prev, .b-hmb-back-link').click(function(){
//////		$("#simplecar").carousel('prev');
//////		return false;
//////	});
//////	*/
//////	if (isMobile) {
//////		$('body').addClass('c-mobile-body');
//////	}

//////	if ($('.b-header').hasClass('b-header-catalog-fixed')) {
//////		headerfixCat = true;
//////	}
//////	else {
//////		headerfixCat = false;
//////	}


//////	doViewWidth();

//////	var windowWidth = viewport().width;



//////	if (!isMobile2) {
//////		$('.b-wrap-infopage-sidenav-filter').stick_in_parent({
//////			parent: '.b-wrap-row-container-special-scroll',
//////			offset_top: 0
//////		});
//////	}


//////	$('.b-rating').rating({
//////		min: 0,
//////		max: 5,
//////		step: 0.5,
//////		language: 'ru',
//////		showClear: false,
//////		showCaption: true,
//////		size: 'xs',
//////		starCaptionClasses: function (val) {
//////			if (val < 0.5) {
//////				return 'label label-default';
//////			}
//////			else return 'label';
//////		}
//////	});


//////	/* b-topbr-slider specialize portal */
//////	$('.b-topbr-slider-list').slick({
//////		slidesToShow: 6,
//////		slidesToScroll: 1,
//////		dots: false,
//////		responsive: [
//////			{
//////				breakpoint: 1200,
//////				settings: {
//////					slidesToShow: 4,
//////					slidesToScroll: 1
//////				}
//////			},
//////			{
//////				breakpoint: 960,
//////				settings: {
//////					slidesToShow: 3,
//////					slidesToScroll: 1
//////				}
//////			},
//////			{
//////				breakpoint: 580,
//////				settings: {
//////					slidesToShow: 2,
//////					slidesToScroll: 1
//////				}
//////			}
//////		]
//////	});


//////	/* special modal tab reg */
//////	$('.b-list-authorize-links a, .authorize-links a').click(function (e) {
//////		var tab = e.target.hash;
//////		if (tab != '') {
//////			$('li > a[href="' + tab + '"]').tab("show");
//////		}
//////	});



//////	/* b-input-date datepicker */
//////	$.datepicker.regional['ru'] = {
//////		closeText: 'Закрыть',
//////		prevText: '',
//////		nextText: '',
//////		currentText: 'Сегодня',
//////		monthNames: ['Январь', 'Февраль', 'Март', 'Апрель', 'Май', 'Июнь',
//////			'Июль', 'Август', 'Сентябрь', 'Октябрь', 'Ноябрь', 'Декабрь'],
//////		monthNamesShort: ['Янв', 'Фев', 'Мар', 'Апр', 'Май', 'Июн',
//////			'Июл', 'Авг', 'Сен', 'Окт', 'Ноя', 'Дек'],
//////		dayNames: ['воскресенье', 'понедельник', 'вторник', 'среда', 'четверг', 'пятница', 'суббота'],
//////		dayNamesShort: ['вск', 'пнд', 'втр', 'срд', 'чтв', 'птн', 'сбт'],
//////		dayNamesMin: ['Вс', 'Пн', 'Вт', 'Ср', 'Чт', 'Пт', 'Сб'],
//////		weekHeader: 'Нед',
//////		dateFormat: 'dd.mm.yy',
//////		firstDay: 1,
//////		isRTL: false,
//////		showMonthAfterYear: false,
//////		yearSuffix: ''
//////	};
//////	$.datepicker.setDefaults($.datepicker.regional['ru']);


//////	$(function () {
//////		var dateFormat = "mm-dd-yy",
//////			from = $("#datefrom")
//////				.datepicker({
//////					defaultDate: "+1w",
//////					dateFormat: "mm-dd-yy",
//////					showOtherMonths: true,
//////					selectOtherMonths: true
//////				})
//////				.on("change", function () {
//////					to.datepicker("option", "minDate", getDate(this));
//////				}),
//////			to = $("#dateto").datepicker({
//////				defaultDate: "+1w",
//////				dateFormat: "mm-dd-yy",
//////				showOtherMonths: true,
//////				selectOtherMonths: true
//////			})
//////				.on("change", function () {
//////					from.datepicker("option", "maxDate", getDate(this));
//////				});

//////		function getDate(element) {
//////			var date;
//////			try {
//////				date = $.datepicker.parseDate(dateFormat, element.value);
//////			} catch (error) {
//////				date = null;
//////			}

//////			return date;
//////		}
//////	});


//////	/* total page scroll header */
//////	if ((!($('.b-product-top-side')[0])) && (!($('.b-compare-product-top-side')[0]))) {

//////		/* custom page scroll header */

//////		onScroll();
//////		$(document).on("scroll", onScroll);

//////		function onScroll(event) {

//////			var body = $('body'), isNavFlying = false;
//////			var scrollTop = $(document).scrollTop();
//////			var fullOffset = $('.b-header').outerHeight() - 30;

//////			if ((scrollTop >= fullOffset) && !isNavFlying && !isMobile2 && !headerfixCat) {
//////				isNavFlying = true;
//////				body.addClass('x-nav-flying-msi');
//////			} else {
//////				if (!isMobile2) {
//////					isNavFlying = false;
//////					body.removeClass('x-nav-flying-msi x-nav-visible');
//////				}
//////			}
//////		}
//////	}



//////	$('.b-header-fixedpopup').hover(function () {
//////		$('body').addClass('x-nav-visible');
//////	}, function () {
//////		$('body').removeClass('x-nav-visible');
//////	});


//////	/* popuplar products slider */
//////	var bPConfigSlider = false;
//////	if ($('.b-popular-products-slider').hasClass('b-pps-config-slider')) {
//////		bPConfigSlider = true;
//////	}

//////	$('.b-popular-products-slider').each(function () {
//////		$(this).slick({
//////			slidesToShow: 4,
//////			slidesToScroll: 1,
//////			dots: false,
//////			responsive: [
//////				{
//////					breakpoint: 1200,
//////					settings: {
//////						slidesToShow: 3,
//////						slidesToScroll: 1
//////					}
//////				},
//////				{
//////					breakpoint: 960,
//////					settings: {
//////						slidesToShow: 2,
//////						slidesToScroll: 1
//////					}
//////				},
//////				{
//////					breakpoint: 580,
//////					settings: {
//////						slidesToShow: 2,
//////						slidesToScroll: 1
//////					}
//////				}
//////			]
//////		});
//////	});

//////	var sliderIsLive = true;
//////	if (bPConfigSlider) {
//////		if (window.innerWidth <= 719) {
//////			$('.b-popular-products-slider').slick('unslick');
//////			sliderIsLive = false;
//////		}
//////	}

//////	if (bPConfigSlider) {
//////		window.addEventListener("resize", function () {
//////			if (window.innerWidth <= 719) {
//////				$('.b-popular-products-slider').slick('unslick');
//////				sliderIsLive = false;
//////			}
//////		});
//////	}



//////	/* popuplar products slider */
//////	$('.b-wocab-features').slick({
//////		slidesToShow: 4,
//////		slidesToScroll: 1,
//////		dots: false,
//////		responsive: [
//////			{
//////				breakpoint: 980,
//////				settings: {
//////					slidesToShow: 3,
//////					dots: true,
//////					slidesToScroll: 1
//////				}
//////			},
//////			{
//////				breakpoint: 680,
//////				settings: {
//////					slidesToShow: 2,
//////					slidesToScroll: 1,
//////					dots: true
//////				}
//////			},
//////			{
//////				breakpoint: 440,
//////				settings: {
//////					slidesToShow: 1,
//////					slidesToScroll: 1,
//////					dots: true
//////				}
//////			}
//////		]
//////	});

//////	/* b-comparsion-slider */
//////	if (isMobile2 || isMobile) {
//////		$('.b-comparsion-slider').slick({
//////			slidesToShow: 1,
//////			slidesToScroll: 1,
//////			variableWidth: true,
//////			infinite: false,
//////			dots: false
//////		});
//////	}

//////	var $myDelivGroup = $('#cdelivaccordion');
//////	$myDelivGroup.on('show.bs.collapse', '.collapse', function () {
//////		$myDelivGroup.find('.collapse.in').collapse('hide');
//////	});

//////	/* top compare popup */
//////	$('.b-3t-compare-box').hover(function () {
//////		if ($(this).parent().hasClass('b-active')) {
//////			clearTimeout($.data(this, 'timer'));
//////			$(this).addClass('compare-box-hover');
//////			$(this).find('.b-3tcb-popup').stop(true, true).slideDown(200);
//////		}
//////	}, function () {
//////		if ($(this).parent().hasClass('b-active')) {
//////			$.data(this, 'timer', setTimeout($.proxy(function () {
//////				$(this).removeClass('compare-box-hover');
//////				$(this).find('.b-3tcb-popup').stop(true, true).slideUp(100);
//////			}, this), 200));
//////		}
//////	});
//////	/* top compare popup fix 1st item hover */
//////	$('.b-3tcb-popup .b-3tcb-popup-list > li:first').hover(function () {
//////		$(this).parent().parent().parent().addClass('compare-box-hover-fix');
//////	}, function () {
//////		$(this).parent().parent().parent().removeClass('compare-box-hover-fix');
//////	});


//////	/*textarea*/
//////	autosize($('textarea'));


//////	/* select */

//////	var $select2form = $('.form-group .b-select').select2({
//////		placeholder: false,
//////		language: 'ru',
//////		dropdownCssClass: 'b-selectform-dropdown'
//////	});

//////	$('.form-group .b-select-city').select2({
//////		placeholder: false,
//////		language: 'ru',
//////		dropdownCssClass: 'b-selectform-dropdown b-selectform-city',
//////		matcher: function (params, data) {
//////			return matchStart(params, data);
//////		}
//////	});

//////	$('.b-obsp-tl-more-link').click(function (e) {
//////		var hrefElem = $(this).attr('href');
//////		if ($(this).hasClass('active')) {
//////			$(this).removeClass('active');
//////			$(hrefElem).animate({ height: '265px' }, 300);
//////			return false
//////		}
//////		else {
//////			$(this).addClass('active');
//////			$(hrefElem).animate({ height: $(hrefElem)[0].scrollHeight }, 200);
//////			return false
//////		}
//////	});


//////	$('.b-i-product-ing-full-toggler a').click(function (e) {
//////		var hrefElem = $(this).parent().prev('.b-i-product-ing-full-cf');
//////		if ($(this).hasClass('active')) {
//////			$(this).removeClass('active');
//////			$(hrefElem).animate({ height: '250px' }, 300).removeClass('visible');
//////			return false
//////		}
//////		else {
//////			$(this).addClass('active');
//////			$(hrefElem).animate({ height: $(hrefElem)[0].scrollHeight }, 200).addClass('visible');
//////			return false
//////		}
//////	});


//////	$('.b-text-article-more-link').click(function (e) {
//////		var hrefElem = $(this).attr('href');
//////		if ($(this).hasClass('active')) {
//////			$(this).removeClass('active');
//////			$(hrefElem).animate({ height: '200px' }, 300);
//////			return false
//////		}
//////		else {
//////			$(this).addClass('active');
//////			$(hrefElem).animate({ height: $(hrefElem)[0].scrollHeight }, 200);
//////			return false
//////		}
//////	});


//////	$('.b-lmo-full-info-head-link').click(function (e) {
//////		var hrefElem = $(this).attr('href');
//////		if ($(this).hasClass('active')) {
//////			$(this).removeClass('active');
//////			$(hrefElem).stop(true, true).animate({ height: '0' }, 300);
//////			return false
//////		}
//////		else {
//////			$(this).addClass('active');
//////			$(hrefElem).stop(true, true).animate({ height: $(hrefElem)[0].scrollHeight }, 200);
//////			return false
//////		}
//////	});


//////	$('.b-lmo-item .b-lmo-header').click(function (e) {
//////		if ($(this).parent().hasClass('b-lmo-item-open')) {
//////			$(this).parent().removeClass('b-lmo-item-open');
//////			return false
//////		}
//////		else {
//////			$(this).parent().addClass('b-lmo-item-open');
//////			return false
//////		}
//////	});

//////	$('.b-hmb-mobnav-toggler').click(function (e) {
//////		if ($('body').hasClass('c-mobnav-active')) {
//////			$('body').removeClass('c-mobnav-active');
//////			$('.b-wrap-all').css('height', 'auto');
//////			return false
//////		}
//////		else {
//////			$('body').addClass('c-mobnav-active');
//////			var tempBodyHeight = $('.b-hmb-popup').outerHeight();
//////			$('.b-wrap-all').css('height', tempBodyHeight + 40 + 'px');
//////			return false
//////		}
//////	});

//////	$('.b-hmb-popup-splash').click(function (e) {
//////		$('body').removeClass('c-mobnav-active').removeClass('c-mobnav-catalog-active');
//////		return false
//////	});

//////	$('.b-link-nwm-catalog').click(function (e) {
//////		$('body').addClass('c-mobnav-catalog-active');
//////		return false
//////	});

//////	$('.b-hmb-mobnav-toggler-catalog').click(function (e) {
//////		$('body').removeClass('c-mobnav-catalog-active');
//////		return false
//////	});

//////	$('.b-hmb-popup').swipeleft(function () {
//////		$('body').removeClass('c-mobnav-active').removeClass('c-mobnav-catalog-active');
//////	});


//////	$(document).on('click', '.b-head-how-link', function () {
//////		$(this).parent().next('.collapse').collapse('toggle');
//////		$(this).toggleClass('active');
//////		return false;
//////	});

//////	/* popover promocode */
//////	var popOverPosition = 'bottom';
//////	if (isMobile3) {
//////		popOverPosition = 'top';
//////	}
//////	$('.b-i-dbpro-box-link').popover({
//////		container: 'body',
//////		placement: popOverPosition,
//////		html: true,
//////		content: function () {
//////			var content = $(this).attr("data-popover-content");
//////			return $(content).html();
//////		}
//////	});
//////	$('[data-toggle="popover"]').popover({
//////		container: 'body',
//////		placement: 'bottom',
//////		html: true,
//////		content: function () {
//////			var content = $(this).attr("data-popover-content");
//////			return $(content).html();
//////		},
//////		template: '<div class="popover popover-colors" role="tooltip"><div class="popover-content"></div></div>'
//////	});


//////	/* tooltips */
//////	$('body').tooltip({ selector: '[data-toggle="tooltip"]', trigger: 'click', placement: 'bottom', delay: { 'show': 0, 'hide': 0 } });

//////	$('.b-popover-attent-link').popover({
//////		container: 'body',
//////		trigger: 'click',
//////		html: true,
//////		content: function () {
//////			var content = $(this).attr("data-popover-content");
//////			return $(content).html();
//////		},
//////		template: '<div class="popover popover-attent" role="tooltip"><div class="popover-content"></div><div class="popover-btn-close"></div></div>'
//////	}).click(function (e) {
//////		$(this).popover('toggle');
//////		e.stopPropagation();
//////	});

//////	$('.b-popover-configset-link').popover({
//////		container: 'body',
//////		trigger: 'click',
//////		html: true,
//////		content: function () {
//////			var content = $(this).attr("data-popover-content");
//////			return $(content).html();
//////		},
//////		template: '<div class="popover popover-configset" role="tooltip"><div class="popover-content"></div><div class="popover-btn-close"></div></div>'
//////	}).click(function (e) {
//////		$(this).popover('toggle');
//////		e.stopPropagation();
//////	});




//////	$(document).on('click', '.popover-btn-close', function () {
//////		$('.b-popover-attent-link').popover('hide');
//////		$('.b-popover-configset-link').popover('hide');
//////	});

//////	$(document).on('click', function (e) {
//////		$('[data-toggle="tooltip"]').each(function () {
//////			if (!$(this).is(e.target) && $(this).has(e.target).length === 0 && $('.tooltip').has(e.target).length === 0) {
//////				(($(this).tooltip('hide').data('bs.tooltip') || {}).inState || {}).click = false  // fix for BS 3.3.6
//////			}

//////		});
//////		$('[data-toggle="popover"], .b-i-dbpro-box-link, .b-popover-attent-link').each(function () {
//////			if (!$(this).is(e.target) && $(this).has(e.target).length === 0 && $('.popover').has(e.target).length === 0) {
//////				(($(this).popover('hide').data('bs.popover') || {}).inState || {}).click = false  // fix for BS 3.3.6
//////			}

//////		});
//////	});


//////	$('.b-i-dbpro-box-link').on('show.bs.popover', function () {
//////		$('.b-i-dbpro-box-link[aria-describedby]').click();
//////	});
//////	$(document).on('click', '.b-btn-popover-close', function () {
//////		$('.b-i-dbpro-box-link[aria-describedby]').click();
//////	});






//////	/* scroll 2 top */

//////	$(window).scroll(function () {
//////		if ($(this).scrollTop() > 200) {
//////			$('.b-go2top').fadeIn();
//////		} else {
//////			$('.b-go2top').fadeOut();
//////		}
//////	});

//////	$('.b-go2top, .b-link-go-top').click(function () {
//////		$('html, body').animate({ scrollTop: 0 }, 800);
//////		return false;
//////	});


//////	$('.carousel:not(.b-order-box-slider)').swiperight(function () { $(this).carousel('prev'); }
//////	);
//////	$('.carousel:not(.b-order-box-slider)').swipeleft(function () { $(this).carousel('next'); }
//////	);

//////	$('.b-last-config-slider-wrap.xx').hover(function () {
//////		$(this).addClass('b-last-config-slider-hover');
//////	}, function () {
//////		$(this).removeClass('b-last-config-slider-hover');
//////	});
//////	/* slider on new-main */
//////	$('.b-last-config-slider.xx').slick({
//////		slidesToShow: 4,
//////		slidesToScroll: 1,
//////		dots: false,
//////		appendArrows: $('.b-last-config-slider-wrap.xx'),
//////		responsive: [
//////			{
//////				breakpoint: 1600,
//////				settings: {
//////					slidesToShow: 4,
//////					slidesToScroll: 2
//////				}
//////			},
//////			{
//////				breakpoint: 1200,
//////				settings: {
//////					slidesToShow: 3,
//////					slidesToScroll: 2
//////				}
//////			},
//////			{
//////				breakpoint: 960,
//////				settings: {
//////					slidesToShow: 2,
//////					slidesToScroll: 1
//////				}
//////			},
//////			{
//////				breakpoint: 720,
//////				settings: {
//////					slidesToShow: 1,
//////					slidesToScroll: 1,
//////					variableWidth: true,

//////				}
//////			},
//////			{
//////				breakpoint: 320,
//////				settings: {
//////					slidesToShow: 1,
//////					slidesToScroll: 1,
//////					variableWidth: true

//////				}
//////			}
//////		]
//////	});
//////	$('.b-last-config-slider-wrap.yy').hover(function () {
//////		$(this).addClass('b-last-config-slider-hover');
//////	}, function () {
//////		$(this).removeClass('b-last-config-slider-hover');
//////	});
//////	$('.b-last-config-slider.yy').slick({
//////		slidesToShow: 4,
//////		slidesToScroll: 1,
//////		dots: false,
//////		appendArrows: $('.b-last-config-slider-wrap.yy'),
//////		responsive: [
//////			{
//////				breakpoint: 1600,
//////				settings: {
//////					slidesToShow: 4,
//////					slidesToScroll: 2
//////				}
//////			},
//////			{
//////				breakpoint: 1200,
//////				settings: {
//////					slidesToShow: 3,
//////					slidesToScroll: 2
//////				}
//////			},
//////			{
//////				breakpoint: 960,
//////				settings: {
//////					slidesToShow: 2,
//////					slidesToScroll: 1
//////				}
//////			},
//////			{
//////				breakpoint: 720,
//////				settings: {
//////					slidesToShow: 1,
//////					slidesToScroll: 1,
//////					variableWidth: true,

//////				}
//////			},
//////			{
//////				breakpoint: 320,
//////				settings: {
//////					slidesToShow: 1,
//////					slidesToScroll: 1,
//////					variableWidth: true

//////				}
//////			}
//////		]
//////	});

//////	if ($('.b-cfgfw-select-form').length > 0) {
//////		var $slider_pr = $('.b-cfgfw-select-form .b-range-slider'),
//////			$lower_pr = $('#lower_pr'),
//////			$upper_pr = $('#upper_pr'),
//////			min_cprice = 0,
//////			max_cprice = parseFloat($slider_pr.attr('data-price_max'));

//////		$lower_pr.val(min_cprice);
//////		$upper_pr.val(max_cprice);

//////		$slider_pr.slider({
//////			orientation: 'horizontal',
//////			range: true,
//////			animate: 0,
//////			min: 0,
//////			max: parseFloat($slider_pr.attr('data-price_max')),
//////			step: parseFloat($slider_pr.attr('data-price_step')),
//////			value: 0,
//////			values: [min_cprice, max_cprice],
//////			slide: function (event, ui) {
//////				$lower_pr.val(parseFloat(ui.values[0]));
//////				$upper_pr.val(parseFloat(ui.values[1]));
//////			},
//////			change: function (event, ui) {
//////				$lower_pr.val(ui.values[0]);
//////				$upper_pr.val(ui.values[1]);
//////			}
//////		});

//////		$lower_pr.change(function () {
//////			var low = parseFloat($lower_pr.val()),
//////				high = parseFloat($upper_pr.val());
//////			low = Math.min(low, high);
//////			$lower_pr.val(low);
//////			$slider_pr.slider('values', 0, low);
//////		});

//////		$upper_pr.change(function () {
//////			var low = parseFloat($lower_pr.val()),
//////				high = parseFloat($upper_pr.val());
//////			high = Math.max(low, high);
//////			$upper_pr.val(high);
//////			$slider_pr.slider('values', 1, high);
//////		});

//////		$('.b-btn-get-started').click(function () {
//////			var href = country_host + '/assembly/smart/';
//////			href += $lower_pr.val() + '-' + $upper_pr.val() + '/';
//////			href += $('.b-cfgfw-select-form [name=dest]:checked').val() + '/';
//////			href += $('.b-cfgfw-select-form [name=manufactor]:checked').val();
//////			window.location.href = href;
//////		});
//////	}
//////	$('#popupErrors').modal();

//////	$('.b-config-final-fix-toggler').click(function () {
//////		if (!$(this).hasClass('collapsed')) {
//////			$('#hardevelContent .b-sfc-line-tw').slideUp();
//////			$('#hardevelContent #collapseTotalContent').slideDown();
//////			$(this).addClass('collapsed').attr('aria-expanded', 'true');
//////		} else {
//////			$('#hardevelContent .b-sfc-line-tw').slideDown();
//////			$('#hardevelContent #collapseTotalContent').slideUp();
//////			$(this).removeClass('collapsed').attr('aria-expanded', 'false');
//////		}
//////	});
//////	$('#collapseTotalContent').on('show.bs.collapse', function (e) {
//////		//$('.b-config-final-fix-wrapper').removeClass('affix').addClass('drop-open');
//////		//alert('Event fired on #' + e.target.id);
//////	});
//////	$('#collapseTotalContent').on('hide.bs.collapse', function (e) {
//////		//$('.b-config-final-fix-wrapper').removeClass('drop-open');
//////		//alert('Event fired on #' + e.target.id);
//////	});
//////	if ((isMobile) || (isMobile2)) {
//////		$('.b-sfconfig-tab .panel-collapse').on('hidden.bs.collapse', function (e) {
//////			e.stopPropagation();
//////			if (!($('.b-sfconfig-tab .panel-collapse').hasClass('in'))) {
//////				$('body').removeClass('hide-scroll')
//////			}
//////		});

//////		$('.b-sfconfig-tab .panel-collapse').on('shown.bs.collapse', function (e) {
//////			e.stopPropagation();
//////			$('body').addClass('hide-scroll')
//////		});
//////	}

//////	/*$('.share').ShareLink({
//////		title: $('meta[property="og:title"]').attr('content'), // title for share message
//////		text: $('meta[property="og:description"]').attr('content'), // text for share message
//////		image: $('meta[property="og:image"]').attr('content'), // optional image for share message (not for all networks)
//////		url: $('meta[property="og:url"]').attr('content'), // link on shared page
//////		class_prefix: 's_', // optional class prefix for share elements (buttons or links or everything), default: 's_'
//////		width: 640, // optional popup initial width
//////		height: 480 // optional popup initial height
//////	});

//////	$('.counter').ShareCounter({
//////		url: $('meta[property="og:url"]').attr('content'), // url for which you want show like counter
//////		class_prefix: 'c_', // optional class prefix for counter elements, default: 'c_'
//////		display_counter_from: 0, // optional to set when counter is display, default: 0
//////		increment: false // Optional. If this option is true you can summarize counters from different sources just using multiple classes for one container.
//////	});*/

//////});




///////*
//////	By Osvaldas Valutis, www.osvaldas.info
//////	Available for use under the MIT License
//////*/

//////'use strict';

//////(function ($, window, document, undefined) {
//////	$('.inputfile').each(function () {
//////		var $input = $(this),
//////			$label = $input.next('label'),
//////			labelVal = $label.html();

//////		$input.on('change', function (e) {
//////			var fileName = '';

//////			if (this.files && this.files.length > 1)
//////				fileName = (this.getAttribute('data-multiple-caption') || '').replace('{count}', this.files.length);
//////			else if (e.target.value)
//////				fileName = e.target.value.split('\\').pop();

//////			if (fileName)
//////				$label.find('span').html(fileName);
//////			else
//////				$label.html(labelVal);
//////		});

//////		// Firefox bug fix
//////		$input
//////			.on('focus', function () { $input.addClass('has-focus'); })
//////			.on('blur', function () { $input.removeClass('has-focus'); });
//////	});
//////})(jQuery, window, document);

$(".b-cwp-item").on('click', function () {
    console.log($(this))
});