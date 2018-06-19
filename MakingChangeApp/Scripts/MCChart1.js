google.charts.load('current', {packages: ['corechart', 'bar']});
google.charts.setOnLoadCallback(drawTitleSubtitle);

function drawTitleSubtitle() {
      var data = google.visualization.arrayToDataTable([
		  ['Lifestyle Data', 'National Averages', 'Missouri Averages'],
          ['Housing',   1574,		1527],
          ['Transportation',   754,		777],
          ['Food',   600,		633],
          ['Retirement',   570,		562],
		  ['Health',   384,		413],
          ['Ent.',   243,		252],
          ['Cash',   174,		159],
          ['Appearel',   150,		131],
		  ['Education',   121,		81],
          ['Misc.',   148,		114],
          ['Personal',   59,		77]
        ]);
	  
      var materialOptions = {
        chart: {
          title: 'Lifestyle Data Monthly Averages (Dollars)',
        },
        hAxis: {
          title: 'National Averages',
          minValue: 0,
        },
        vAxis: {
          title: 'Lifestyle Data'
        },
        bars: 'vertical'
      };
      var materialChart = new google.charts.Bar(document.getElementById('chart_div'));
      materialChart.draw(data, materialOptions);
    }