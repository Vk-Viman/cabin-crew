// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
// Highlight current nav link by comparing link href to window.location.pathname.
// Works for sidebar and top nav links.
// Loads on DOMContentLoaded.
document.addEventListener('DOMContentLoaded', function () {
    function normalizePath(href) {
        // Use an <a> element to reliably parse hrefs (handles absolute/relative)
        const a = document.createElement('a');
        a.href = href;
        // remove trailing slashes, keep root as '/'
        return (a.pathname || '').replace(/\/+$/, '') || '/';
    }

    const current = (location.pathname || '').replace(/\/+$/, '') || '/';
    const navSelectors = '.sidebar .nav-link, .navbar .nav-link, .nav .nav-link';
    const links = document.querySelectorAll(navSelectors);

    // Clear any previous active states and find exact match
    let foundExact = false;
    links.forEach(link => {
        link.classList.remove('active');
        const href = link.getAttribute('href');
        if (!href || href.startsWith('#') || href.startsWith('javascript:')) return;
        const linkPath = normalizePath(href);
        if (linkPath === current) {
            link.classList.add('active');
            foundExact = true;
        }
    });

    // If no exact match, mark the best prefix match (e.g., /Crew for /Crew/Details/5)
    if (!foundExact) {
        let bestMatch = null;
        links.forEach(link => {
            const href = link.getAttribute('href');
            if (!href) return;
            const linkPath = normalizePath(href);
            if (linkPath === '/') return; // skip root when looking for deeper matches
            if (current.startsWith(linkPath)) {
                if (!bestMatch || linkPath.length > bestMatch.path.length) {
                    bestMatch = { el: link, path: linkPath };
                }
            }
        });
        if (bestMatch) {
            bestMatch.el.classList.add('active');
        } else {
            // optional: mark root if nothing else matched
            links.forEach(link => {
                if (normalizePath(link.getAttribute('href')) === '/') link.classList.add('active');
            });
        }
    }
});