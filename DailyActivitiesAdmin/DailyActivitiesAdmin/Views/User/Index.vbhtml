@ModelType IEnumerable(Of User)
@Code
ViewData("Title") = "Index"
End Code

<h2>Index</h2>

<p>
    @Html.ActionLink("Create New", "Create")
</p>
<table class="table">
    <tr>
        <th>
            @Html.DisplayNameFor(Function(model) model.user_name)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.gender)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.dob)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.pob)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.job)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.job_place)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.civil_status)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.tel)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.email)
        </th>
        <th></th>
    </tr>

@For Each item In Model
    @<tr>
        <td>
            @Html.DisplayFor(Function(modelItem) item.user_name)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.gender)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.dob)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.pob)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.job)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.job_place)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.civil_status)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.tel)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.email)
        </td>
        <td>
            @Html.ActionLink("Edit", "Edit", New With {.id = item.user_id }) |
            @Html.ActionLink("Details", "Details", New With {.id = item.user_id }) |
            @Html.ActionLink("Delete", "Delete", New With {.id = item.user_id })
        </td>
    </tr>
Next

</table>
