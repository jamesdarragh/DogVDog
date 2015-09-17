var darragh = {
    layout: {}
    , page: {
        handlers: {}
        , startUp: null
    }
    , services: {}
};


darragh.layout.startUp = function () {

    console.debug("sabio.layout.startUp");

    //this does a null check on sabio.page.startUp
    if (darragh.page.startUp) {
        console.debug("darragh.page.startUp");
        darragh.page.startUp();
    }
};
$(document).ready(darragh.layout.startUp);