var gulp = require('gulp')
var browserify = require('gulp-browserify');
var rename = require('gulp-rename');
var watch = require('gulp-watch');

gulp.task('scripts', function () {
    gulp.src('./Scripts/App/app.js')
        .pipe(browserify({
            insertGlobals: false,
            debug: false
        }))
        .pipe(rename('app.bundle.js'))
        .pipe(gulp.dest('./Scripts'));
});

gulp.task('watch', function () {
 
    watch('Scripts/App/**/*.js' , function (files, cb) {        
        gulp.start('scripts', cb);
    });
});

gulp.task('default', ['scripts', 'watch']);