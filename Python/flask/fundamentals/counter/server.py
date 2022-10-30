from flask import Flask, render_template, request, redirect, session
app = Flask(__name__)
app.secret_key = 'keep it secret, keep it safe'


@app.route('/')
def count():
    if 'click_count' not in session:
        session['click_count'] = 1
    if 'visit_count' not in session:
        session['visit_count'] = 1
    else:
        session['visit_count'] += 1
    return render_template('index.html')

@app.route('/count')
def click():
    session['click_count'] += 2
    session['visit_count'] -= 1
    return redirect('/')

@app.route('/reset')
def reset():
    session['click_count'] = 1
    session['visit_count'] = 0
    return redirect('/')

@app.route('/increment', methods = ['POST']) 
def increment():
    session['click_count'] += int(request.form['increment'])
    return redirect('/')


if __name__=="__main__": 
    app.run(debug=True) 