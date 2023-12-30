function SelectAll(id, gv) {
    //get reference of GridView control
    var grid = document.getElementById(gv);
    //variable to contain the cell of the grid
    var cell;

    if (grid.rows.length > 0) {
        //loop starts from 1. rows[0] points to the header.
        for (i = 1; i < grid.rows.length; i++) {
            //get the reference of first column
            cell = grid.rows[i].cells[1];

            //loop according to the number of childNodes in the cell
            for (j = 0; j < cell.childNodes.length; j++) {
                //if childNode type is CheckBox                 
                if (cell.childNodes[j].type == "checkbox") {
                    //assign the status of the Select All checkbox to the cell checkbox within the grid
                    cell.childNodes[j].checked = document.getElementById(id).checked;
                }
            }
        }
    }
}
function ShowHide(obj, obj1) {
    window.scrollTo(0, 0);
    var d = document.getElementById(obj);
    var d2 = document.getElementById(obj1);
    if (d.style.display == 'none') {
        d.style.display = 'block';
        d2.style.display = 'none';
    }
    else {
        d.style.display = 'none';
        d2.style.display = 'block';
    }

}