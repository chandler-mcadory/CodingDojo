from flask_app import app
from flask import render_template,redirect,request,session,flash
from flask_app.models.user_model import User
from flask_app.models.recipe_model import Recipe


# RECIPE_NEW TEMPLATE
@app.route('/recipes/new')
def new_recipe():
    return render_template("recipe_new.html")

# NEW RECIPE
@app.route('/recipes/create', methods=['POST'])
def create_recipe():
    if 'user_id' not in session:
        return redirect('/')
    if not Recipe.validator(request.form):
        return redirect('/recipes/new')
    recipe_data = {
        **request.form,
        'user_id': session['user_id']
    }
    Recipe.create(recipe_data)
    return redirect('/dashboard')

# SHOW ONE RECIPE
@app.route('/recipes/<int:id>')
def show_one_recipe(id):
    if 'user_id' not in session:
        return redirect('/')
    this_recipe = Recipe.get_by_id({'id':id})
    return render_template("/recipe_one.html", this_recipe = this_recipe)


# EDIT RECIPE
@app.route('/recipes/<int:id>/edit')
def edit_user_form(id):
    if 'user_id' not in session:
        return redirect('/')
    data = {
        'id':id
    }
    one_recipe = Recipe.get_by_id(data)
    return render_template('recipe_edit.html', one_recipe = one_recipe)

# UPDATE RECIPE
@app.route('/recipes/<int:id>/update', methods = ['POST'])
def update_recipe(id):
    if 'user_id' not in session:
        return redirect('/')
    if not Recipe.validator(request.form):
        return redirect(f'/recipes/{id}/edit')
    data = {
        'id':id,
        **request.form
    }
    Recipe.update(data)
    return redirect('/dashboard')

# DELETE RECIPE
@app.route('/recipes/<int:id>/delete')
def delete_recipe(id):
    if 'user_id' not in session:
        return redirect('/')
    Recipe.delete({'id':id})
    return redirect('/dashboard')