var ctx = document.getElementById('myChart').getContext('2d');
var myChart = new Chart(ctx, {
    type: 'pie',
    data: {
        labels: ['Червоний', 'Зелений', 'Синій'],
        datasets: [{
            label: 'Кольори',
            data: [12, 19, 3],
            backgroundColor: [
                'rgba(255, 99, 132, 0.8)',
                'rgba(75, 192, 192, 0.8)',
                'rgba(54, 162, 235, 0.8)'
            ]
        }]
    },
    options: {
        title: {
            display: true,
            text: 'Кольори'
        },
        responsive: true,
        maintainAspectRatio: false,
        legend: {
            position: 'bottom',
            labels: {
                fontSize: 16
            }
        }
    }
});