(function () {
	var dataLabelName = "JS - Move Worklist";
	$('.runtime-form').append('<div class="slideout"><div class="slideout__tab"></div><form class="slideout__form"><div class="slideout__placeholder"/></form></div>');
	var view = $('[name="' + dataLabelName + '"]').closest('.view');
	var viewHeader = $(view).find('.panel-header');
	$(viewHeader).appendTo('.slideout__tab');
	$(view).appendTo('.slideout__form');
	var slideToggle = function () {
		var slideout = $(".slideout");
		return slideout[0].classList.toggle('show');
	};
	$(function () {
		$('.slideout__form .SourceCodeFormsControlsWorklist table.nav .headerTxt').on('click', slideToggle);
		return $(".slideout__tab").on('click', slideToggle);
	});	
  
	var worklist = $(view).find('.SFC.SourceCode-Forms-Controls-Web-ControlPack-Worklist');
	var worklistId = $(worklist).attr('id');
	var worklistItems = $(worklist).find('.WorkListGridTableBody')[0];
  	//Listening to Worklist 
	var observer = new MutationObserver(function(mutations){
		mutations.forEach(function(mutation) {
			setWorklistStatus();
		});
	});
	var config = { childList: true, subtree: true };
	observer.observe(worklistItems, config);
    
    //changing the Header color to red, when we have tasks
	var setWorklistStatus = function(){
		var wlItems = JSON.parse(localStorage.getItem(worklistId))['WorklistItems'];
		if (wlItems.length > 0) {
			$('.slideout__tab .panel-header-wrapper').css('background-color', '#990000');
		} else {
			$('.slideout__tab .panel-header-wrapper').css('background-color', '');
		}
	};
  setWorklistStatus();
})();