from flask_app import app
from flask import render_template,redirect,request,session,flash
from flask_app.models.dojo_model import Dojo


@app.route('/')
def send_home():
    return redirect('/dojos')

@app.route('/dojos') 
def homepage():
    all_dojos = Dojo.get_all()
    return render_template('dojos.html', all_dojos = all_dojos)

@app.route('/dojos/create', methods = ['POST'])
def create_dojo():
    Dojo.create(request.form)
    return redirect('/dojos')

@app.route('/dojos/<int:id>/show')
def show_dojo(id):
    the_dojo = []
    the_dojo.append(Dojo.get_one({'id':id}))
    print(the_dojo)
    return render_template('dojo_show.html', the_dojo = the_dojo)

