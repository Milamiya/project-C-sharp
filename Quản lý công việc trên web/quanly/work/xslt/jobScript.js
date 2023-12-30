<!--
        function formatDate(format, day) {
        var year, month, date, fullDate;

        year = day.getYear();
        year = year < 1900 ? year + 1900 : year;

        month = day.getMonth() + 1;

        date = day.getDate();

        if (format == "yyyy-mm-dd" || format == "yyyy/mm/dd") {
            fullDate = year + "-" + month + "-" + date;
        }
        else if (format == "mm-dd-yyyy" || format == "mm/dd/yyyy") {
            fullDate = month + "-" + date + "-" + year;
        }
        else if (format == "dd-mm-yyyy" || format == "dd/mm/yyyy") {
            fullDate = date + "-" + month + "-" + year;
        }
        return fullDate;
    }
    function showButton(btnName) {
        btnName.disabled = false;
        return;
    }
    function hideButton(btnName) {
        btnName.disabled = true;
        return;
    }
    function testCheckBox(checkbox, btnName) {
        if (checkbox.checked == true) {
            showButton(btnName);
        }
        else {
            hideButton(btnName);
        }
        return;
    }
    function testUploadFile(textbox, btnName) {
        if (textbox.value == "") {
            hideButton(btnName);
        }
        else {
            showButton(btnName);
        }
    }
//-->