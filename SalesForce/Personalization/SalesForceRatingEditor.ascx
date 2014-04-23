
<label for="rating" class="sfTxtLbl">{$CustomPersonalizationResources, LeadRating$}</label>
<select id="rating">
    <option value="1">{$CustomPersonalizationResources, Hot$}</option>
    <option value="2">{$CustomPersonalizationResources, Warm$}</option>
    <option value="3">{$CustomPersonalizationResources, Cold$}</option>
</select>

<script type="text/javascript">
        $(document).ready(function () {
            debugger
            if (document.URL.toString().indexOf("personalization-console", 0) != -1) {
                document.getElementById("ratingLabel").style.display = "none";
            } else {
                document.getElementById("ratingLabel").style.display = "block";
            }
        })

        function CriterionEditor() {
        }

        CriterionEditor.prototype = {
            //Used as a label for the criterion when viewing the user segment
            getCriterionTitle: function () {
                return "SalesForce lead status"
            },
            //The descriptive value for the criterion
            getCriterionDisplayValue: function () {
                return rating.options[rating.selectedIndex].text;
            },

            //Persists the input from the user as a value for the criterion
            getCriterionValue: function () {
                debugger;
                return rating.options[rating.selectedIndex].value;
            },

            //When the editor opens, sets the previously persisted value
            //as initial value for the criterion
            setCriterionValue: function (val) {
                rating.value = val;
            },

            errorMessage: "",

            isValid: function () {
                debugger
                return true;
            }
        };
</script>
