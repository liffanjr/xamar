const gulp = require('gulp')
    , sass = require('gulp-sass')
    , uglify = require("gulp-uglify")
    , minify = require('gulp-minify');

gulp.task('css',
    /**
     * Compiles the sass to css.
     * @returns {css};
     * */
    function () {
        return gulp.src('./Style/*.scss')
            .pipe(sass.sync().on('error', sass.logError))
            .pipe(gulp.dest('./NutriThink/Assets/css'));
    });

gulp.task('watch',
    /**
     * Watches for changes in te 'Style' folder.
     * When a changes has bin saved te 'sass' is called.
     * */
    function () {
        gulp.watch('./Style/**/*.scss', gulp.series('css'));
    });

// I think this is not deeded
//gulp.task('js',
///**
// * minifys & uglifys the js.
// * @returns {js.min};
// * */
//function () {
//    return gulp.src([
//        './Javascript/*.js',
//        './Javascript/**/*.js'
//    ])
//        //.pipe(minify())
//        //.pipe(uglify())
//        .pipe(gulp.dest('./wwwroot/js'));
//});
//
//gulp.task('watch-js',
//    /**
//     * Watches for changes in te 'Javascript' folder.
//     * When a changes has bin saved te 'js' is called.
//     * */
//    function () {
//        gulp.watch('./Javascript/**/*.js', gulp.series('js'));
//    });
