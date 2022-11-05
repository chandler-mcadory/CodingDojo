from flask_app import app
from flask import render_template,redirect,request,session,flash
from flask_app.models.user_model import User



@app.route('/') 
def homepage():
    all_users = User.get_all()
    return render_template('read_all.html', all_users = all_users)

@app.route('/users/new')
def new():
    return render_template('create.html')

@app.route('/users/create', methods = ['POST'])
def create_user():
    User.create(request.form)
    return redirect('/')

@app.route('/users/<int:id>/edit')
def edit_user(id):
    return render_template("edit.html",user=User.get_one({'id':id}))

@app.route('/users/<int:id>/update',methods=['POST'])
def update(id):
    data = {
        **request.form,
        'id' : id
    }
    User.update(data)
    return redirect('/')

@app.route('/users/<int:id>/show')
def show(id):
    return render_template("show_user.html",user=User.get_one({'id':id}))

@app.route('/users/<int:id>/destroy')
def delete_user(id):
    User.delete({"id" : id})
    return redirect('/')