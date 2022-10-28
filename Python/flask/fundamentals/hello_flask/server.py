from flask import Flask, render_template  # Import Flask to allow us to create our app
app = Flask(__name__)    # Create a new instance of the Flask class called "app"
@app.route('/')        # ALWAYS NEED ONE WITH JUST A / AS THE DEFAULT PAGE         # The "@" decorator associates this route with the function immediately following

def index(): 
    return render_template("index.html", phrase="howdy", times=3)

def hello_world():
    return 'Hello World!'
    
@app.route('/success')
def success():
    return "success"   
    
@app.route('/hello/<name>')
def hello(name):
    return "Hello, " + name
    
    # Return the string 'Hello World!' as a response
if __name__=="__main__":   # Ensure this file is being run directly and not from a different module    
    app.run(debug=True)    # Run the app in debug mode.


# import statements, maybe some other routes
    

    
# app.run(debug=True) should be the very last statement! 

