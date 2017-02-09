@ModelType User
@Code
    ViewData("Title") = "Details"
End Code

<h2>Details</h2>

<div>
    <h4>User</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.user_name)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.user_name)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.gender)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.gender)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.dob)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.dob)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.pob)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.pob)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.job)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.job)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.job_place)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.job_place)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.civil_status)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.civil_status)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.tel)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.tel)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.email)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.email)
        </dd>

    </dl>
</div>
<p>
    @Html.ActionLink("Edit", "Edit", New With { .id = Model.user_id }) |
    @Html.ActionLink("Back to List", "Index")
</p>
