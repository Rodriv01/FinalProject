$(document).ready(function () {
    // Send an AJAX request
    $.getJSON("/api/party")
        .done(function (data) {
            // On success, 'data' contains a list of products.
            $.each(data, function (key, item) {
                var candidatesHTML = "";
                $.each(item.Candidates, (key, candidate) => {
                    candidatesHTML += `<div class="col"><p> ` + candidate.Position + ` <img class=" img-fluid" src=` + candidate.ImgPath + ` alt="card image"></p></div>\n`
                })
                var myCol = $('<div class="col-xs-12 col-sm-6 col-md-4">');
                var myPanel = $(`<div class="image-flip" ontouchstart="this.classList.toggle('hover');">
                            <div class="mainflip">
                                <div class="frontside">
                                    <div class="card">
                                        <div class="card-body text-center">
                                            <p><img class=" img-fluid" src=`+ item.LogoPath +` alt="card image"></p>
                                            <h4 class="card-title">`+ item.Abbreviation +`</h4>
                                        </div>
                                    </div>
                                </div>
                                <div class="backside">
                                    <div class="card">
                                        <div class="card-body text-center mt-4">
                                            <div class="row">
                                                `+ candidatesHTML +`
                                            </div>
                                            <button class="btn btn-outline-danger btn-block">Votar</button>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>`);
                myPanel.appendTo(myCol);
                myCol.appendTo('#card-deck');
            });
        });
});