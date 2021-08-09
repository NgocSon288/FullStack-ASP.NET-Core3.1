const paginationObj = {
    init: function () {
        this.loadPageActive(1)     // Init First page
        this.loadEventClick()
        this.loadSearchSubmit()

        this.loadDeleteRow()
    },
    loadPageActive: function (activePage, keyword) {
        if (!keyword) {
            keyword = document.getElementById("txt-search").value
        }
        const img = document.getElementById('img-empty-list')
        const paginationItemPrevious = document.querySelector(".pagination-item-previous")
        const paginationItemNext = document.querySelector(".pagination-item-next")
        const paginatioItemNumber = document.querySelectorAll('.pagination-item-number')
        const settings = document.getElementById("pagination-settings")
        let items = document.querySelectorAll(".row-paginate-item")   // danh sách tất cả các item
        items = keyword ? [...items].filter(it => it.textContent.toLowerCase().indexOf(keyword.toLowerCase()) >= 0) : [...items]
        //const itemsCount = settings.dataset.itemscount      // tổng số item     cần tính tóa lại, vì nó ảnh hưởng đến số lượng trang
        const itemsCount = items.length      // tổng số item     cần tính tóa lại, vì nó ảnh hưởng đến số lượng trang
        const pageSize = settings.dataset.pagesize          // pageSize
        if (itemsCount <= (activePage - 1) * pageSize) {
            activePage--;
        }
        const start = (activePage - 1) * pageSize           // item đầu
        const end = pageSize - 1 + start                    // item cuối
        const enableItems = [...items].slice(start, end + 1)

        this.disableAllItems()

        enableItems.forEach((val, ind) => {
            let sttItem = val.querySelector('.row-paginate-item-stt')
            sttItem.innerHTML = ind - 0 + start + 1
            val.classList.remove("d-none")
        })

        // Cập nhật lại pageIndex
        let pageCount = Math.floor((itemsCount - 1 + (pageSize - 0)) / pageSize);
        settings.dataset.pagecount = pageCount

        var is = [...paginatioItemNumber];
        paginationObj.disableActivePagination()
        is.forEach((val, i) => {
            if (i === activePage - 1) {
                val.classList.add('active')
            }

            if (i >= pageCount) {
                val.classList.add('d-none')
            } else {
                val.classList.remove('d-none')
            }
        })

        if (!pageCount) {
            paginationItemPrevious.classList.add('d-none')
            paginationItemNext.classList.add('d-none')
        } else {
            paginationItemPrevious.classList.remove('d-none')
            paginationItemNext.classList.remove('d-none')
        }

        settings.dataset.pagecount = pageCount
        settings.dataset.activepage = activePage

        if (itemsCount <= 0) {
            img.classList.remove('d-none')
        } else {
            img.classList.add('d-none')
        }

    },
    loadEventClick: function () {
        const paginationItemNumber = document.querySelectorAll(".pagination-item-number")
        const paginationItemPrevious = document.querySelector(".pagination-item-previous")
        const paginationItemNext = document.querySelector(".pagination-item-next")
        const currentActivePage = document.getElementById("pagination-settings")
        let currentActivePageDataset = currentActivePage.dataset.activepage


        // For number
        paginationItemNumber.forEach(function (item) {
            item.addEventListener('click', function (e) {
                e.preventDefault()
                const activeNumber = this.children[0].text

                currentActivePageDataset = activeNumber
                currentActivePage.dataset.activepage = currentActivePageDataset
                paginationObj.activeItemIndex(currentActivePageDataset)
            })
        })

        // For previous, next
        paginationItemPrevious.addEventListener('click', function (e) {
            e.preventDefault()

            currentActivePageDataset = currentActivePageDataset > 1 ? currentActivePageDataset - 1 : 1
            currentActivePage.dataset.activepage = currentActivePageDataset
            paginationObj.activeItemIndex(currentActivePageDataset)

        })

        paginationItemNext.addEventListener('click', function (e) {
            e.preventDefault()

            const pageCount = currentActivePage.dataset.pagecount

            currentActivePageDataset = currentActivePageDataset < pageCount ? currentActivePageDataset - 0 + 1 : pageCount
            currentActivePage.dataset.activepage = currentActivePageDataset
            paginationObj.activeItemIndex(currentActivePageDataset)

        })

    },
    activeItemIndex: function (index) {
        paginationObj.disableActivePagination()
        const paginationItemNumber = document.querySelectorAll(".pagination-item-number")
        paginationItemNumber[index - 1].classList.add("active")
        paginationObj.loadPageActive(index)
    },
    disableAllItems: function () {
        const items = $(".row-paginate-item");

        [...items].forEach(val => {
            val.classList.add("d-none")
        })
    },
    disableActivePagination: function () {
        const paginationItemNumber = document.querySelectorAll(".pagination-item-number")

        paginationItemNumber.forEach(function (item) {
            item.classList.remove("active")
        })
    },
    loadSearchSubmit: function () {
        const btnSearch = document.getElementById("btn-search")

        btnSearch.addEventListener('click', function () {
            const txtSearch = document.getElementById("txt-search")
            const keyword = txtSearch.value

            paginationObj.loadPageActive(1, keyword)
        })
    },
    loadDeleteRow: function () {
        const btnDeletes = document.querySelectorAll('.btn-delete-row');

        btnDeletes.forEach(item => {
            item.addEventListener('click', function (e) {
                e.preventDefault()

                const url = this.href
                const parentRow = this.closest('.row-paginate-item')
                const id = this.dataset.id

                // gọi API xóa nếu thành công thì xoa1 this
                if (confirm("Bạn có muốn xóa?")) {
                    $.ajax({
                        url: url,
                        type: 'get',
                        data: { id },
                        success: function (res) {
                            console.log(res)
                            if (res.isSuccessfully) {
                                // Cập nhật lại UI

                                parentRow.remove()
                                alert(res.messageError)

                                const settings = document.getElementById("pagination-settings")
                                const activePage = settings.dataset.activepage

                                paginationObj.loadPageActive(activePage)

                            } else {
                                alert("Xóa không thành công")
                            }
                        },
                        error: function () {
                            alert('Xóa không thành công!')
                        }
                    })
                }

            })
        })
    }
}