$(function() {
	'use strict'
	
	//Data table example
    var table = $('#exportexample').DataTable({
        scrollX: true,
        pageLength: 100,
        lengthMenu: [[100, 500, -1], [100, 500, "All"]], // Sets up the amount of records to display
        language: {
            searchPlaceholder: 'Search...',
            sSearch: '',
        },
        dom: "<'row'<'col-sm-2'l><'col-sm-7 text-center'B><'col-sm-3'f>>tipr",
		//buttons: [ 'excel', 'pdf', 'colvis' ]
        buttons: [
            {
                extend: "excel",
                className: "btn-sm btn-success",
                titleAttr: 'Export as Excel',
                text: 'Excel',
                init: function (api, node, config) {
                    $(node).removeClass('btn-light')
                }
            },
            {
                extend: "pdf",
                className: "btn-sm btn-danger",
                titleAttr: 'Export as PDF',
                text: 'PDF',
                init: function (api, node, config) {
                    $(node).removeClass('btn-light')
                }
            },
            {
                extend: "colvis",
                className: "btn-sm btn-warning",
                titleAttr: 'Column Visibility',
                text: 'Column Visibility',
                init: function (api, node, config) {
                    $(node).removeClass('btn-light')
                }
            },
        ],
	} );
	table.buttons().container()
        .appendTo('#exportexample_wrapper .col-md-6:eq(0)');
	
	
	$('#example1').DataTable({
		language: {
			searchPlaceholder: 'Search...',
			sSearch: '',
			lengthMenu: '_MENU_ items/page',
		}
	});
	$('#example2').DataTable({
		responsive: true,
		language: {
			searchPlaceholder: 'Search...',
			sSearch: '',
			lengthMenu: '_MENU_ items/page',
		}
	});
	$('#example3').DataTable( {
        responsive: {
            details: {
                display: $.fn.dataTable.Responsive.display.modal( {
                    header: function ( row ) {
                        var data = row.data();
                        return 'Details for '+data[0]+' '+data[1];
                    }
                } ),
                renderer: $.fn.dataTable.Responsive.renderer.tableAll( {
                    tableClass: 'table'
                } )
            }
        }
    } );
	
	/*Input Datatable*/
	 var table = $('#example-input').DataTable({
      'columnDefs': [
         {
            'targets': [1, 2, 3, 4, 5],
            'render': function(data, type, row, meta){
               if(type === 'display'){
                  var api = new $.fn.dataTable.Api(meta.settings);

                  var $el = $('input, select, textarea', api.cell({ row: meta.row, column: meta.col }).node());

                  var $html = $(data).wrap('<div/>').parent();

                  if($el.prop('tagName') === 'INPUT'){
                     $('input', $html).attr('value', $el.val());
                     if($el.prop('checked')){
                        $('input', $html).attr('checked', 'checked');
                     }
                  } else if ($el.prop('tagName') === 'TEXTAREA'){
                     $('textarea', $html).html($el.val());

                  } else if ($el.prop('tagName') === 'SELECT'){
                     $('option:selected', $html).removeAttr('selected');
                     $('option', $html).filter(function(){
                        return ($(this).attr('value') === $el.val());
                     }).attr('selected', 'selected');
                  }

                  data = $html.html();
               }

               return data;
            }
         }
      ],
      'responsive': true
   });
   $('#example-input tbody').on('keyup change', '.child input, .child select, .child textarea', function(e){
       var $el = $(this);
       var rowIdx = $el.closest('ul').data('dtr-index');
       var colIdx = $el.closest('li').data('dtr-index');
       var cell = table.cell({ row: rowIdx, column: colIdx }).node();
       $('input, select, textarea', cell).val($el.val());
       if($el.is(':checked')){
          $('input', cell).prop('checked', true);
       } else {
          $('input', cell).removeProp('checked');
       }
   });
	
});