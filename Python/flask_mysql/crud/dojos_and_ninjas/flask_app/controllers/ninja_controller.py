from flask_app import app
from flask import render_template,redirect,request,session,flash
from flask_app.models.ninja_model import Ninja
from flask_app.models.dojo_model import Dojo


@app.route('/ninjas/new')
def new_ninja():
    all_dojos = Dojo.get_all()
    return render_template('ninja_new.html', all_dojos = all_dojos)

@app.route('/ninja/new_ninja', methods = ['POST'])
def create_ninja():
    Ninja.create_ninja(request.form)
    return redirect(f'/dojos/{request.form["dojo_id"]}/show')