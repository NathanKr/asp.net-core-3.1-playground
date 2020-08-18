<h2>This is a CRUD razor web pages application with book<h2>
<h2>Point of interest</h2>
<ul>
	<li>No scafolding is used</li>
	<li>server and client side validation is implemented</li>
	<li>model binding - MVVM is used on pages</li>
	<li>Tag helper used : input , label , validation , select</li>
	<li>NotFound page is implemented and redirected to when resource is not found</li>
	<li>UI is done using bootstrap 4 which is part of the the project by default</li>
	<li>Create \ Edit page are implemented using form bootstrap component</li>
	<li>Details page is using card bootstrap component </li>
	<li>Books page is using table bootstrap component </li>
	<li>Books can be strored in memory using MockBooksRepository or in sql server using SqlBooksRepository services</li>
	<li>SqlBooksRepository is implemented easyly using Entitiy Framework core via database migration based on model class</li>
	<li>books repository is implemented using respoistory design pattern</li>
	<li>Dependency injection is used with IBooksRepository to choose repo implementation</li>
	<li>Partial View is implementd via _BookDetailsPartial to reuse book details in Details and Delete pages</li>
	<li>View component is implemented via BooksCountByCategoryViewComponent to reuse view + logic</li>
	<li>Use Linq : GroupBy ,Select</li>
</ul>
